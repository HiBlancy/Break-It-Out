using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveLives : MonoBehaviour
{
    void OnEnable()
    {
        Debug.Log("1 UP");
        BallLives.Obj.ballLives = BallLives.Obj.ballLives + 1;
        TextOnScreen.Obj.UpdateOnScreen();
        gameObject.SetActive(false);
    }
}