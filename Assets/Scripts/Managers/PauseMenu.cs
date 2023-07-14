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
        StartCoroutine("Pausing");
    }
    IEnumerator Pausing()
    {
        yield return new WaitForSeconds(0.3f);
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0;
        StopCoroutine("Pausing");
    }
    public void Close()
    {
        StartCoroutine("Closing");
    }
    IEnumerator Closing()
    {
        yield return new WaitForSeconds(0.3f);
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void MainMenu()
    {
        StartCoroutine("MainMenuScene");
    }
    IEnumerator MainMenuScene()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }
    public void Restart()
    {
        StartCoroutine("Restarting");
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
        StartCoroutine("Starting");
    }
    IEnumerator Starting()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
    public void Quit()
    {
        StartCoroutine("Quiting");
    }
    IEnumerator Quiting()
    {
        yield return new WaitForSeconds(0.3f);
        Application.Quit();
    }
}
