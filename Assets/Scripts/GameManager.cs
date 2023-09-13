using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
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
    private void Play()
    {
        score = 0;

        scoreText.text = score.ToString();
    }
    private void Pause()
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
