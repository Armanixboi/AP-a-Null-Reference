using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] float duration;
    [SerializeField] string nextScene;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Nextscene()
    {
        StartCoroutine("StartingNextScene");
        //Time.timeScale = 1;
        //SceneManager.LoadScene("Main Menu");
    }
    IEnumerator StartingNextScene()
    {
        float timer = 0;
        while (timer < duration)
        {
            timer += Time.unscaledDeltaTime;
            yield return null;
        }
        SceneManager.LoadScene(nextScene);

    }
}
