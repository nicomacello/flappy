using UnityEngine;


public class PipeMiddleScript : MonoBehaviour
{
    private logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    //delete update

    // checkers that see if the players collide with the midle of two pipe 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
            if (logic.playerScore > logic.playerRecord)
            {
                logic.playerBestScore();
            }
        }  
        
    }
    
}