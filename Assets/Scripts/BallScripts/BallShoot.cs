using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShoot : MonoBehaviour
{
    public static BallShoot obj;

    [SerializeField] Vector2 initialVelocity;
    Rigidbody2D ballRb;
    public bool isBallMoving;

    void Awake()
    {
        obj = this;
    }

    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ResetPositions.obj.ResetPositionsBoth();
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
        ballRb.constraints = RigidbodyConstraints2D.None;
        transform.parent = null;
        ballRb.velocity = initialVelocity;
        isBallMoving = true;
    }

    void OnDestroy()
    {
        obj = null;
    }
}