using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVelociyBall : MonoBehaviour
{
    Rigidbody2D ballRb;
    void Start()
    {
        ballRb = GameObject.FindWithTag("Ball").GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        BallShoot.Obj.initialVelocity = new Vector2(Random.Range(-8, 8), Random.Range(-8, 8));
        gameObject.SetActive(false);
    }
}