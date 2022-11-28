using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager obj;
    public int score;

    void Awake()
    {
        obj = this;
    }
    public void AddScore(int giveScore)
    {
        score += giveScore;
        TextOnScreen.obj.UpdateOnScreen();
    }

    void OnDestroy()
    {
        obj = null;
    }
}