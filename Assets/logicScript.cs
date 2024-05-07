using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{   //variables
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    public GameObject pause;
    public GameObject scelte;

    //command insert in unity 
    [ContextMenu("Incrases Score")]

    // method for increment the score
    public void addScore(int ScoreToAdd)
    {
        playerScore = playerScore + ScoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    // method for restart button 
    public void restartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
       
    }

    // this method active the game over 
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        pause.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pause.SetActive(false);
        scelte.SetActive(true);

    }
    public void Continue()
    {
        scelte.SetActive(false);
        pause.SetActive(true);
        Time.timeScale = 1f;
    }




    
}
