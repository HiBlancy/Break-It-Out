using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Obj { get; private set; }
    public int score;
    void Awake()
    {
        if (Obj != null && Obj != this)
            Destroy(this);
        else
            Obj = this;
    }
    public void AddScore(int giveScore)
    {
        score += giveScore;
        TextOnScreen.Obj.UpdateOnScreen();
    }
}