using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderFall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            BallLives.Obj.LoseHealt();
            ResetPositions.Obj.ResetPositionsBoth();
        }

        if (collision.gameObject.CompareTag("Brick"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}