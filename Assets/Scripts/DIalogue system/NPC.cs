using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour
{

    public DialogueManager dialogueManager;
    public Image npcDialogueImage;
    public string npcDialogueName;
    public List<string> npcdialogue;



    private void Start()
    {
        dialogueManager = FindAnyObjectByType<DialogueManager>();
    }


    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            dialogueManager.playerIsClose = true;
            dialogueManager.npcScript = this;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueManager.playerIsClose = false;
            dialogueManager.npcScript = null;
            dialogueManager.EndText();

        }
    }

}
