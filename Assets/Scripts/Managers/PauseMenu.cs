using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuPanel;

    void Update()
    {
        
    }

    public void Pause()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Continue()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void MainMenuScene()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }
    public void Restart()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
    }
    public void GameScene()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}