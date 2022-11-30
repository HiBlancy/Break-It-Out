using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScale : MonoBehaviour
{
    public static PlayerScale Obj { get; private set; }
    Transform player;

    public float scale;

    void Awake()
    {
        if (Obj != null && Obj != this)
            Destroy(this);
        else
            Obj = this;
    }
    void Start()
    {
        scale = 3;
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        player.transform.localScale = new Vector2(scale, 0.2f);
    }
}