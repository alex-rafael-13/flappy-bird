using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Private as it does not need to be changed on game manager
    private int score;

    //Game Over function needs to be called
    public void GameOver()
    {
        Debug.Log("Game Over Test");
    }

    //Func that increases score
    public void IncreaseScore()
    {
        score ++;
    } 
}
