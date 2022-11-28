using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositions : MonoBehaviour
{
    public static ResetPositions obj;

    Transform player;
    Rigidbody2D ballRb;
    void Awake()
    {
        obj = this;
    }

    void Start()
    {
        ballRb = GameObject.FindWithTag("Ball").GetComponent<Rigidbody2D>();

        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    public void ResetPositionsBoth()
    {
        //player
        player.transform.position = new Vector2(0, -4.5f);

        //ball
        ballRb.transform.position = new Vector2(0, -4.1f);
        ballRb.constraints = RigidbodyConstraints2D.FreezeAll;
        BallShoot.obj.transform.SetParent(player);
        BallShoot.obj.isBallMoving = false;
    }

    void OnDestroy()
    {
        obj = null;
    }
}