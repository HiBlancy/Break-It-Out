using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOnScreen : MonoBehaviour
{
    public static TextOnScreen Obj { get; private set; }

    [SerializeField] Text currentBallLives;

    void Awake()
    {
        if (Obj != null && Obj != this)
            Destroy(this);
        else
            Obj = this;
    }
    public void UpdateOnScreen()
    {
        currentBallLives.text = "" + BallLives.Obj.ballLives;
    }
}