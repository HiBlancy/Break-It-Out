using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public static PlayerMovment obj;

    public float moveSpeedPlayer;
    readonly float bounds = 7.33f;

    void Awake()
    {
        obj = this;
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

    void OnDestroy()
    {
        obj = null;
    }
}