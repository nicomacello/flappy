using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scriptbird : MonoBehaviour
{  // variables
    public Rigidbody2D myRigidbody;
    public float flapSrenght;
    private logicScript logic;
    public bool birdIsAlive = true;
    public GameObject Bird;
    public GameObject mainMenu;
    [SerializeField] private  pipeMoveScript pipe;
    private float timer = 0;
    public bool invincible = false;
    [SerializeField] public GameObject crown;


    // Start is called before the first frame update
    //change indentation
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        pipe = GameObject.FindGameObjectWithTag("Pipe").GetComponent<pipeMoveScript>();
    }

    // Update is called once per frame
    void Update()
    {   //chekers that see if the bird is alive
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapSrenght;
        }

        /*if (transform.position.x == -45 || transform.position.y == -18)
        {

            birdIsAlive = false;
            logic.gameOver();

        }

        else if (transform.position.x == 45 || transform.position.y == 18)
        {

            birdIsAlive = false;
            logic.gameOver();
            
        }*/
    }
    //method for confirm the game over 
    //change indentation
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        logic.gameOver();
        birdIsAlive = false;
        Debug.Log("Bird Delted");
        Destroy(gameObject);
        
    }
    

    //method for the button start 
    public void startGame()
    {
        
        Debug.Log("main Menu Deleted");
        Bird.SetActive(true);
        mainMenu.SetActive(false);
        birdIsAlive = true;
        powerUp();
        
        //not work
        //pipe.restartPipe();
        
    }
    public void powerUp()
    {

        StartCoroutine(TimerInvincible());





        /*invincible = true;
        if (invincible == true)
        {
            GetComponent<Collider2D>().enabled = false;
            
            timer = timer * Time.deltaTime;
            
        }
        else if (timer <= 3)
        {
            invincible = false;
            GetComponent<Collider2D>().enabled = true;
            
        }*/
    }

    private IEnumerator TimerInvincible()
    {
        invincible = true;
        if (invincible == true)
        {
            GetComponent<Collider2D>().enabled = false;
            crown.SetActive(true);
        }

            yield return new WaitForSeconds(5f);

        if (timer <= 3)
        {
            invincible = false;
            GetComponent<Collider2D>().enabled = true;
            crown.SetActive(false);

        }


    }
}
