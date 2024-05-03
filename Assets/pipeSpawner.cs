using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{   //variables 
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    private logicScript logic;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();

    }

    // Update is called once per frame
    //when a pipe is out the screen it becames delete thanks the checkers of the deltaTime 
    void Update()
    {   
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    //pipe spawn in randoom position 
    
    private void spawnPipe()
    {
         float lowestPoint = transform.position.y - heightOffset;
         float heighestpoint = transform.position.y + heightOffset;

         Instantiate(pipe, new Vector3(transform.position.x, Random.Range (lowestPoint, heighestpoint), 0), transform.rotation);
    }
    public void difficultEasy()
    {
        spawnRate = 3.5f;
    }
    public void difficultMedium()
    {
        spawnRate = 2.5f;
    }

    public void difficultHell()
    {
        spawnRate = 1.5f;
    }

    /*public void restartPipe()
    {
        if (transform.position.x <= 5)
        {
            Debug.Log("Pipe Delted");
            Destroy(gameObject);
        }
    }*/
}