using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text playerOneScore;
    public Text playerTwoScore;
    public GameManager gameManager;

    public int score1;
    public int score2;
    public float goalsToWin;

    public void Start()
    {
        score1 = 0;
        score2 = 0;
    }

    public void UpdatePlayerOneScore()
    {
        score1++;
        playerOneScore.text = score1.ToString();

        if (score1 == goalsToWin)
        {
            bool player1Wins = true;
            gameManager.GameOver(player1Wins);
        }
        else
        {
            bool player1Start = false;
            gameManager.ResetGame(player1Start);
        }
    }

    public void UpdatePlayerTwoScore()
    {
        score2++;
        playerTwoScore.text = score2.ToString();

        if (score2 == goalsToWin)
        {
            bool player1Wins = false;
            gameManager.GameOver(player1Wins);
        }
        else
        {
            bool player1Start = true;
            gameManager.ResetGame(player1Start);
        }
    }
}
