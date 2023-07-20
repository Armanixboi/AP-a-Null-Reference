using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public float duration;

    void Update()
    {
        
    }
    public void Pause()
    {
        
        StartCoroutine("Pausing");
        //pauseMenuPanel.SetActive(true);
        //Time.timeScale = 0;
    }
    IEnumerator Pausing()
    {

        yield return new WaitForSeconds(0.3f);
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0;

    }
    public void Close()
    {
        StartCoroutine(Closing());
        //pauseMenuPanel.SetActive(false);
        //Time.timeScale = 1;
    }
    IEnumerator Closing()
    {
        float timer = 0;
        while (timer < duration) 
        {
            timer += Time.unscaledDeltaTime;
            yield return null;
        }
        Time.timeScale = 1;
        pauseMenuPanel.SetActive(false);
    }
    public void MainMenu()
    {
        StartCoroutine("MainMenuScene");
        //Time.timeScale = 1;
        //SceneManager.LoadScene("Main Menu");
    }
    IEnumerator MainMenuScene()
    {
        float timer = 0;
        while (timer < duration)
        {
            timer += Time.unscaledDeltaTime;
            yield return null;
        }
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
        
    }
    public void Restart()
    {
        StartCoroutine("Restarting");
        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadScene(currentSceneIndex);
        //Time.timeScale = 1;
    }
    IEnumerator Restarting()
    {
        float timer = 0;
        while (timer < duration)
        {
            timer += Time.unscaledDeltaTime;
            yield return null;
        }
        Time.timeScale = 1;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    public void GameScene()
    {
        StartCoroutine("Starting");
        //SceneManager.LoadScene("Main");
        //Time.timeScale = 1;
    }
    IEnumerator Starting()
    {
        float timer = 0;
        while (timer < duration)
        {
            timer += Time.unscaledDeltaTime;
            yield return null;
        }
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }
    public void Quit()
    {
        StartCoroutine("Quiting");
        //Application.Quit();
    }
    IEnumerator Quiting()
    {
        float timer = 0;
        while (timer < duration)
        {
            timer += Time.unscaledDeltaTime;
            yield return null;
        }
        Application.Quit();
    }
}
