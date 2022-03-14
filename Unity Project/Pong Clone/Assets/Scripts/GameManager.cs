using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject player1;
    public GameObject player2;

    public void ResetGame(bool player1Start)
    {
        // Reset moving objects velocity
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        ball.gameObject.GetComponent<BallBehaviour>().hitCounter = 0;
        player1.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        player2.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

        // Reset moving objects position
        ball.GetComponent<Rigidbody2D>().position = new Vector2(0f, 0f);
        player1.GetComponent<Rigidbody2D>().position = new Vector2(-425f, 0f);
        player2.GetComponent<Rigidbody2D>().position = new Vector2(425f, 0f);

        // Start next round
        ball.gameObject.GetComponent<BallBehaviour>().StartBall(player1Start);
    }

    public void GameOver(bool player1Wins)
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 1:
                if (player1Wins)
                    SceneManager.LoadScene(4);
                if (!player1Wins)
                    SceneManager.LoadScene(5);
                break;
            case 2:
                if (player1Wins)
                    SceneManager.LoadScene(6);
                if (!player1Wins)
                    SceneManager.LoadScene(7);
                break;
            default:
                break;
        }

        /*
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (player1Wins)
                SceneManager.LoadScene(4);
            if (!player1Wins)
                SceneManager.LoadScene(5);
        }
            
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (player1Wins)
                SceneManager.LoadScene(6);
            if (!player1Wins)
                SceneManager.LoadScene(7);
        }
        */
            
    }

}
