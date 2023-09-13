using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Player player;
    public GameObject playButton;     
    public GameObject gameOver;     
    //Private as it does not need to be changed on game manager
    private int score;

    private void Awake()
    {
        //Set framerate
        Application.targetFrameRate = 60;

        Pause();
    }
    
    public void Play()
    {
        score = 0;

        scoreText.text = score.ToString();
        gameOver.SetActive(false);
        playButton.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        //Destroy all pipes from previous run
        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++) {
            Destroy(pipes[i].gameObject);
        }
    }
    public void Pause()
    {
        //This pauses the game
        Time.timeScale = 0f;
        //Disable the player so they won't be able to move
        player.enabled = false;
    }

    //Game Over function needs to be called
    public void GameOver()
    {
        //Shows game over message
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    //Func that increases score
    public void IncreaseScore()
    {
        score ++;
        scoreText.text = score.ToString();
    } 
}
