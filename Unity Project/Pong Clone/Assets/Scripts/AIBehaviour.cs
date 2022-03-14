using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBehaviour : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D myRigidbody;
    public Transform ball;

    void FixedUpdate()
    {
        if (ball.position.y == myRigidbody.position.y)
            myRigidbody.velocity.Set(0f, 0f);

        if (ball.position.y > myRigidbody.position.y)
            myRigidbody.AddForce(new Vector2(0f, 1f * speed));

        if (ball.position.y < myRigidbody.position.y)
            myRigidbody.AddForce(new Vector2(0f, -1f * speed));
    }
}
