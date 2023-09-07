using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Private as it does not need to be changed on game manager
    private int score;

    public void GameOver()
    {
        Debug.Log("Game Over");
    }

    //Func that increases score
    public void IncreaseScore()
    {
        score ++;
    } 
}
