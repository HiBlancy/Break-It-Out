using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickCountOnScreen : MonoBehaviour
{
    public static BrickCountOnScreen Obj { get; private set; }

    int blocksLeft;

    void Awake()
    {
        if (Obj != null && Obj != this)
            Destroy(this);
        else
            Obj = this;
    }
    void Start()
    {
        blocksLeft = GameObject.FindGameObjectsWithTag("Brick").Length;
    }

    public void BlocksDestroyed()
    {
        blocksLeft--;
        if (blocksLeft <= 0)
            LoadNextLevel();
    }
   
    void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}