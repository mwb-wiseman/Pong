using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Behaviour : MonoBehaviour
{
    public float speed;
    public Rigidbody2D myRigidbody;

    void FixedUpdate()
    {
        Vector2 moveUp = new Vector2(0f, 1f);
        Vector2 moveDown = new Vector2(0f, -1f);


        if (Input.GetKeyDown(KeyCode.UpArrow))
            myRigidbody.velocity.Set(0f, 0f);

        if (Input.GetKey(KeyCode.UpArrow))
            myRigidbody.AddForce(moveUp * speed);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            myRigidbody.velocity.Set(0f, 0f);

        if (Input.GetKey(KeyCode.DownArrow))
            myRigidbody.AddForce(moveDown * speed);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

    }
}
