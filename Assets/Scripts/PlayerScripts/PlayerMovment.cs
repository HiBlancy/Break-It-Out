using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public static PlayerMovment Obj { get; private set; }

    public float moveSpeedPlayer;
    readonly float bounds = 7.33f;

    void Awake()
    {
        if (Obj != null && Obj != this)
            Destroy(this);
        else
            Obj = this;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");

        Vector2 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x + moveInput * moveSpeedPlayer * Time.deltaTime, -bounds, bounds);
        transform.position = playerPosition;
    }
}