using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D myRigidbody;

    void FixedUpdate()
    {
        Vector2 moveUp = new Vector2(0f, 1f);
        Vector2 moveDown = new Vector2(0f, -1f);

        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyUp(KeyCode.W))
            myRigidbody.velocity.Set(0f, 0f);

        if (Input.GetKey(KeyCode.W))
            myRigidbody.AddForce(moveUp * speed);
        
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyUp(KeyCode.S))
            myRigidbody.velocity.Set(0f, 0f);

        if (Input.GetKey(KeyCode.S))
            myRigidbody.AddForce(moveDown * speed);
            
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

    }
}
