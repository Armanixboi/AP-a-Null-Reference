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
        //StartCoroutine("Pausing");
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0;
    }
    IEnumerator Pausing()
    {
        yield return new WaitForSeconds(0.3f);
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0;

    }
    public void Close()
    {
        // StartCoroutine("Closing");
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }
    IEnumerator Closing()
    {
        yield return new WaitForSeconds(0.3f);
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void MainMenu()
    {
        // StartCoroutine("MainMenuScene");
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }
    IEnumerator MainMenuScene()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }
    public void Restart()
    {
        // StartCoroutine("Restarting");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
    }
    IEnumerator Restarting()
    {
        yield return new WaitForSeconds(0.3f);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
    }
    public void start()
    {
        //  StartCoroutine("Starting");
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
    IEnumerator Starting()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
    public void Quit()
    {
        // StartCoroutine("Quiting");
        Application.Quit();
    }
    IEnumerator Quiting()
    {
        yield return new WaitForSeconds(0.3f);
        Application.Quit();
    }
}
