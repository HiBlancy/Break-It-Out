using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    Rigidbody2D ballRb;

    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        FixOrientation();
    }
    void FixOrientation()
    {
        float velocityDealta = 0.5f;
        float minVelocity = 0.2f;

        if (Mathf.Abs(ballRb.velocity.x) < minVelocity)
        {
            velocityDealta = Random.value < 0.5f ? velocityDealta : -velocityDealta;
            ballRb.velocity += new Vector2(velocityDealta, 0f);
        }
        if (Mathf.Abs(ballRb.velocity.y) < minVelocity)
        {
            velocityDealta = Random.value < 0.5f ? velocityDealta : -velocityDealta;
            ballRb.velocity += new Vector2(0f, velocityDealta);
        }
    }
}