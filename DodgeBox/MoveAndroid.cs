using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveAndroid : MonoBehaviour
{
    private bool moveLeft;
    private bool moveRight;
    private Rigidbody2D rb;
    float forwardSpeed = 0.06f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        if (moveLeft && !moveRight) { 
            rb.AddForce(Vector3.left * forwardSpeed);
       
        }

        if (moveRight && !moveLeft) { 
           rb.AddForce(Vector2.right * forwardSpeed);
    }

    }
    public void MoveMeLeft()
    {
        moveLeft = true;
    }

    public void StopMeLeft()
    {
        moveLeft = false;
    }
    public void MoveMeRight()
    {
        moveRight = true;
    }

    public void StopMeRight()
    {
        moveRight = false;
    }

}
