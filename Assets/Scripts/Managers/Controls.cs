using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public GameObject controlsPanel;
    public float duration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Functions////////////////////////////////////////////////////////////////////
    public void ControlsPanel()
    {
        StartCoroutine(ControlsPaneling());
        //controlsPanel.SetActive(true);
        //Time.timeScale = 0;
    }
    
    public void Close()
    {
        StartCoroutine(ClosingControlsPanel());
        //controlsPanel.SetActive(false);
        //Time.timeScale = 1;
    }

    //Coroutines////////////////////////////////////////////////////////////////////
    IEnumerator ClosingControlsPanel()
    {
        float timer = 0;
        while (timer < duration)
        {
            timer += Time.unscaledDeltaTime;
            yield return null;
        }
        controlsPanel.SetActive(false);
        Time.timeScale = 1;
    }
    IEnumerator ControlsPaneling()
    {
        float timer = 0;
        while (timer < duration)
        {
            timer += Time.unscaledDeltaTime;
            yield return null;
        }
        controlsPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
