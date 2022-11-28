using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderFall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {          
            ResetPositions.obj.ResetPositionsBoth();

            BallLives.obj.LoseHealt();
        }
        //if colision es un upgrade simplemente se destruye
    }
}