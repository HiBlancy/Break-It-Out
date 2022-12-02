using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasterPlayer : MonoBehaviour
{
    Rigidbody2D player;

    void OnEnable()
    {
        Debug.Log("Player faster");
        PlayerMovment.Obj.moveSpeedPlayer = PlayerMovment.Obj.moveSpeedPlayer + 0.5f;
        gameObject.SetActive(false);
    }

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
    }
}