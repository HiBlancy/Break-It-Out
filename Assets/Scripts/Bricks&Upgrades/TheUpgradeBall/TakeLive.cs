using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeLive : MonoBehaviour
{
    void OnEnable()
    {
        BallLives.Obj.ballLives = BallLives.Obj.ballLives - 1;
        TextOnScreen.Obj.UpdateOnScreen();
        gameObject.SetActive(false);
    }
}