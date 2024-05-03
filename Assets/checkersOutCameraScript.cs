using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkersOutCameraScript : MonoBehaviour
{
    private logicScript logic;
    private scriptbird bird;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        bird = GameObject.FindGameObjectWithTag("bird").GetComponent<scriptbird>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnBecameInvisible()
    {
        SceneManager.LoadScene("gameOver");
    }
}