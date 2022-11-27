using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderFall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            collision.gameObject.SetActive(false);
            BallLives.obj.LoseHealt();
            //no destruir la pelota, si no ponerla sobre la pala

        }
        //if colision es un upgrade simplemente se destruye
    }
}