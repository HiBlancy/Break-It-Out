using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLives : MonoBehaviour
{
    public static BallLives obj;

    [SerializeField] GameObject gameOverPanel;
    public int ballLives;
    void Awake()
    {
        obj = this;
    }

    void Start()
    {
        ballLives = 3;
    }

    public void LoseHealt()
    {
        ballLives--;
        TextOnScreen.obj.UpdateOnScreen();
        ChekingHealt();
    }

    public void GiveHeath()
    {
        ballLives++;
    }

    void ChekingHealt()
    {
        if(ballLives == 0)
        {
            gameOverPanel.SetActive(true);
        }
    }
    void OnDestroy()
    {
        obj = null;
    }
}