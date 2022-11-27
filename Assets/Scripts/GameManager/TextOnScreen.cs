using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOnScreen : MonoBehaviour
{
    public static TextOnScreen obj;

    [SerializeField] Text currentBallLives;
    [SerializeField] Text currentScore;

    void Awake()
    {
        obj = this;
    }

    public void UpdateOnScreen()
    {
        currentBallLives.text = "" + BallLives.obj.ballLives;
        currentScore.text = "" + ScoreManager.obj.score;
    }

    void OnDestroy()
    {
        obj = null;
    }
}