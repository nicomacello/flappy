using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pipeMoveScript : MonoBehaviour
{   //variables
    //public GameObject pipe;
    public float moveSpeed = 5;
    public float deadZone = -45;
    

    //delete start 

    // Update is called once per frame
    //checkers if the pipe is in the deadzone 
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {

            Debug.Log("Pipe Delted");
            Destroy(gameObject);

        }
    }
}