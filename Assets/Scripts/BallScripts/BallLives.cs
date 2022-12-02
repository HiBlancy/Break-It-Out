using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLives : MonoBehaviour
{
    public static BallLives Obj { get; private set; }

    [SerializeField] GameObject gameOverPanel;

    [SerializeField] AudioSource gameOverSound;
    [SerializeField] AudioSource fallSound;
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
        fallSound.Play();

        if (ballLives <= 0)
        {
            gameOverSound.Play();
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }

        TextOnScreen.Obj.UpdateOnScreen();
    }

    public void GiveHeath()
    {
        ballLives++;
    }
}