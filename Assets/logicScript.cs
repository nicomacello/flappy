using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class logicScript : MonoBehaviour
{   //variables
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    public GameObject pause;
    public GameObject scelte;
    //public GameObject bird;
    public TextMeshProUGUI recordText;
    public int playerRecord;
    [SerializeField] public scriptbird bird;
    [SerializeField] public pipeMoveScript pipe;

    //command insert in unity 
    [ContextMenu("Incrases Score")]
    [ContextMenu("incrases Record")]

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
        //pipe.deadZone = -5;
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
    public void playAgain()
    {
        gameOverScreen.SetActive(false);
        bird.mainMenu.SetActive(true);
        //bird.setActive(true);
        //pipe.deadZone = -5;
        playerScore = 0;
        bird.birdIsAlive = true;
        bird.restartPosition();
        pause.SetActive(true);

    }
    
    public void playerBestScore()
    {
           playerRecord = playerScore;
           recordText.text = playerRecord.ToString();
        
    }
    public void resetRecord()
    {
        playerRecord = 0;
    }
}
