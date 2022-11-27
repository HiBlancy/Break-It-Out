using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovmentBall : MonoBehaviour
{
    public  Vector2 initialVelocity;

    Rigidbody2D ballRb;
    bool isBallMoving;

    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isBallMoving)
        {
            Launch();
        }
    }

    void Launch()
    {
        transform.parent = null;
        ballRb.velocity = initialVelocity;
        isBallMoving = false;
    }
}