using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public NPC npcScript;
    public bool playerisclose;
    void Start()
    {

    }


    void Update()
    {
        if(playerisclose)
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
            playerisclose = true;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerisclose = false;
        }
    }
}
