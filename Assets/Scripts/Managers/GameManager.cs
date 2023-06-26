using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public NPC npcScript;
    public bool playerIsClose;
    void Start()
    {

    }


    void Update()
    {
        if(playerIsClose)
        {
            npcScript.enabled = true;
        }
        else
        {
            npcScript.enabled = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
        }
    }
}
