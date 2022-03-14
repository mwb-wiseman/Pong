using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public GameObject ball;
    public ScoreController scoreController;
    public AudioManager audioManager;

    // Ball collision with Player Rackets
    public Vector2 PlayerCollision(Collision2D c, Vector2 ballDirection)
    {
        Vector3 ballPosition = ball.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;
        float racketHeight = c.collider.bounds.size.y;

        ballDirection.Set(ballDirection.x * -1, (ballPosition.y - racketPosition.y) / racketHeight);
        audioManager.PlayObjectSound(c.collider.gameObject);

        return ballDirection;
    }

    // Ball collision with Top and Bottom Boundaries
    public Vector2 BoundaryCollision(Collision2D c, Vector2 ballDirection)
    {
        ballDirection.Set(ballDirection.x, ballDirection.y * -1);
        audioManager.PlayObjectSound(c.collider.gameObject);

        return ballDirection;
    }

    // Ball collision with goal
    public void GoalCollision(Collision2D c)
    {
        switch (c.collider.name)
        {
            case "BoundaryLeft":
                scoreController.UpdatePlayerTwoScore();
                if(scoreController.score2 < scoreController.goalsToWin)
                    audioManager.PlayObjectSound(c.collider.gameObject);
                break;
            case "BoundaryRight":
                scoreController.UpdatePlayerOneScore();
                if (scoreController.score1 < scoreController.goalsToWin)
                    audioManager.PlayObjectSound(c.collider.gameObject);
                break;
            default:
                break;
        }
    }

}
