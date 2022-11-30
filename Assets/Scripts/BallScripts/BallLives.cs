using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLives : MonoBehaviour
{
    public static BallLives Obj { get; private set; }

    [SerializeField] GameObject gameOverPanel;
    public int ballLives;
    void Awake()
    {
        if(Obj != null && Obj != this)
            Destroy(this);
        else
            Obj = this;
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

        TextOnScreen.Obj.UpdateOnScreen();
    }

    public void GiveHeath()
    {
        ballLives++;
    }
}