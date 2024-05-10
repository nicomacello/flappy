using UnityEngine;


public class pipeMoveScript : MonoBehaviour
{   //variables
    //public GameObject pipe;
    public float moveSpeed = 5;
    public float deadZone = -45;
    //[SerializeField] public scriptbird bird;
    

    //delete start 

    // Update is called once per frame
    //checkers if the pipe is in the deadzone 
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        /*else if (bird.birdIsAlive == false)
        {
            deadZone = 0;
        }
        else
        {
            deadZone = -45;
        }*/
    }
}