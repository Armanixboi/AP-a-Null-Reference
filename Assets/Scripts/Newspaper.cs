using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newspaper : MonoBehaviour
{
    public GameObject newsPaper;
    public bool playerCanRead;

    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && playerCanRead)
        {
            newsPaper.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && newsPaper.activeSelf)
        {
            newsPaper.SetActive(false);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerCanRead = true;  
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {


        if (other.CompareTag("Player"))
        {
            playerCanRead = false;
            newsPaper.SetActive(false);
        }

    }
}
