using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScale : MonoBehaviour
{
    Transform ball;

    public float scalex;
    public float scaley;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindWithTag("Ball").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ball.transform.localScale = new Vector2(scalex, scaley);
    }
}
