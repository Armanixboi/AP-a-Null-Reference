using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC1 : MonoBehaviour
{
    DialogueManager dialogueManager;


    private void Start()
    {
        dialogueManager = GetComponent<DialogueManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           // playerIsClose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           // playerIsClose = false;
            dialogueManager.EndText();
        }
    }


}
