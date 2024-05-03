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
       
    }

    // this method active the game over 
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }


    
}
