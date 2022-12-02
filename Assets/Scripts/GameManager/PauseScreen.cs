using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] GameObject optionsPanel;
    static bool GamePaused = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                BackToGame();
            }
            else
            {
                Pause();
            }
        }
    }

    public void ResetLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void BackToGame()
    {
        Time.timeScale = 1f;
        optionsPanel.SetActive(false);
        GamePaused = false;
    }
    void Pause()
    {
        Time.timeScale = 0f;
        optionsPanel.SetActive(true);
        GamePaused = true;
    }
}