using System.Collections;
using UnityEngine;


public class scriptbird : MonoBehaviour
{  // variables
    public Rigidbody2D myRigidbody;
    public float flapSrenght;
    [SerializeField] public logicScript logic;
    public bool birdIsAlive = true;
    public GameObject Bird;
    public GameObject mainMenu;
    [SerializeField] private  pipeMoveScript pipe;
    private float timer = 0;
    public bool invincible = false;
    [SerializeField] public GameObject crown;
    public GameObject pause;
    public GameObject item;
    public GameObject skin;
    public GameObject cowboy;
    public GameObject baseball;
    public GameObject skull;
    public float countdown = 0;
    Vector3 StartPosition;


    // Start is called before the first frame update
    //change indentation
    void Start()
    {
        //bruh non usare il gameobject.find
        //logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        //pipe = GameObject.FindGameObjectWithTag("Pipe").GetComponent<pipeMoveScript>();
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   //chekers that see if the bird is alive
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapSrenght;
        }
        if (transform.position.x < -20)
        {
            logic.gameOver();
            //pipe.deadZone = -5;
            birdIsAlive = false;
            Bird.SetActive(false);
            restartPosition();
        }
        else if (transform.position.y > 17 || transform.position.y < -17)
        {
            logic.gameOver();
            //pipe.deadZone = -5;
            birdIsAlive = false;
            Bird.SetActive(false);
            restartPosition();
        }
    }
    //method for confirm the game over 
    //change indentation
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive == true && invincible == false)
        {
        logic.gameOver();
        birdIsAlive = false;
        //pipe.deadZone = -5;
        //Debug.Log("Bird Delted");
        Bird.SetActive(false);
        }
    }
    

    //method for the button start 
    public void startGame()
    {
        //Debug.Log("main Menu Deleted");
        Bird.SetActive(true);
        mainMenu.SetActive(false);
        birdIsAlive = true;
        powerUp();
        pause.SetActive(true);
        item.SetActive(true);
        //pipe.deadZone = -45;
        //pausaPlayer();
    }
    public void skinMenu()
    {
        mainMenu.SetActive(false);
        Time.timeScale = 0f;
        skin.SetActive(true);
    }
    public void cowboyHat()
    {
        cowboy.SetActive(true);
        mainMenu.SetActive(true);
        Time.timeScale = 1f;
        skin.SetActive(false);
        baseball.SetActive(false);
        skull.SetActive(false);
    }
    public void baseballHat()
    {
        baseball.SetActive(true);
        mainMenu.SetActive(true);
        Time.timeScale = 1f;
        skin.SetActive(false);
        skull.SetActive(false);
        cowboy.SetActive(false);
    }
    public void skullMask()
    {
        skull.SetActive(true);
        mainMenu.SetActive(true);
        Time.timeScale = 1f;
        skin.SetActive (false);
        cowboy.SetActive (false);
        baseball.SetActive (false);
    }
    public void normalBird()
    {
        skull.SetActive(false);
        baseball.SetActive(false);  
        cowboy.SetActive (false);
        mainMenu.SetActive(true); 
        skin.SetActive(false);
        Time.timeScale = 1f;
    }
    public void powerUp()
    {
        StartCoroutine(TimerInvincible());
    }

    private IEnumerator TimerInvincible()
    {
        invincible = true;

        //GetComponent<Collider2D>().enabled = false;

        crown.SetActive(true);

            yield return new WaitForSeconds(5f);

        if (timer <= 3)
        {
            invincible = false;

            //GetComponent<Collider2D>().enabled = true;

            crown.SetActive(false);
        }
    }
    public void pausaPlayer()
    {
        StartCoroutine (CountdownPlayer());
    }
    

    public IEnumerator CountdownPlayer()
    {

        Time.timeScale = 0f;

        yield return new WaitForSeconds(2f);

        if (timer <= 1f)
        {
            Time.timeScale = 1f;
        }
    }
    public void restartPosition()
    {
        if (birdIsAlive == false)
        { 
            Bird.transform.position = StartPosition; 
        }
    }
}
