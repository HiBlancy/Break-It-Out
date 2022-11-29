using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShoot : MonoBehaviour
{
    public static BallShoot Obj { get; private set; }

    [SerializeField] Vector2 initialVelocity;
    Rigidbody2D ballRb;
    public bool isBallMoving;

    void Awake()
    {
        if (Obj != null && Obj != this)
            Destroy(this);
        else
            Obj = this;
    }

    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ballRb.constraints = RigidbodyConstraints2D.FreezeAll;
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
}