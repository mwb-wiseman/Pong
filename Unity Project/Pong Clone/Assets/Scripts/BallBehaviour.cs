using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{

    public float baseSpeed;
    public float speedIncreasePerHit;
    public float maxExtraSpeed;
    public int hitCounter = 0;

    public CollisionController collisionController;
    public Vector2 ballDirection;

    void Awake()
    {
        float coinToss = Random.value;
        bool player1Start = true;

        if (coinToss >= 0.5)
            player1Start = true;
        else if (coinToss < 0.5)
            player1Start = false;

        StartCoroutine(StartBallWithDelay(player1Start));
    }

    public void FixedUpdate()
    {
        float speed = baseSpeed + hitCounter * speedIncreasePerHit;
        Rigidbody2D myRigidbody = this.gameObject.GetComponent<Rigidbody2D>();

        if (speed > baseSpeed + maxExtraSpeed)
        {
            speed = baseSpeed + maxExtraSpeed;
            myRigidbody.velocity = ballDirection * speed;
        }
        else
            myRigidbody.velocity = ballDirection * speed;
    }

    public IEnumerator StartBallWithDelay(bool player1Start)
    {
        yield return new WaitForSeconds(2);
        if (player1Start)
            ballDirection.Set(-1f, 0f);
        else
            ballDirection.Set(1f, 0f);
    }
    
    public void StartBall(bool player1Start)
    {
        if (player1Start)
            ballDirection.Set(-1f, 0f);
        else
            ballDirection.Set(1f, 0f);
    }

    public void OnCollisionEnter2D(Collision2D c)
    {
        switch (c.collider.tag)
        {
            case "Player":
                hitCounter++;
                ballDirection = collisionController.PlayerCollision(c, ballDirection);
                break;
            case "Boundary_TopAndBottom":
                ballDirection = collisionController.BoundaryCollision(c, ballDirection);
                break;
            case "Boundary_LeftAndRight":
                collisionController.GoalCollision(c);
                break;
            default:
                break;
        }
    }

}
