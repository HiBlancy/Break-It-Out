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

        if (ballLives <= 0)
        {
            Time.timeScale = 0f;
            gameOverPanel.SetActive(true);
        }

        TextOnScreen.obj.UpdateOnScreen();
    }

    public void GiveHeath()
    {
        ballLives++;
    }

    void OnDestroy()
    {
        obj = null;
    }
}