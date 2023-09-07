
using System.Diagnostics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Private as it does not need to be changed on game manager
    private int score;

    private void GameOver()
    {
        Debug.log("Game Over");
    }

    //Func that increases score
    private void IncreaseScore()
    {
        score ++;
    } 

}
