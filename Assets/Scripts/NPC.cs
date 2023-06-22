using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI Name;
    public string npcName;
    public string[] dialogue;
    private int index;
    public GameObject nextButton;
    public float wordSpeed;
    public bool playerIsClose;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && playerIsClose)
        {
            if(dialoguePanel.activeInHierarchy)
            {
                EndText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        Name.text = npcName;
        if (dialogueText.text == dialogue[index])
        {
            nextButton.SetActive(true);
        }

    }

    public void EndText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach(char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text+= letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextDialogue()
    {
        nextButton.SetActive(false);

        if(index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            EndText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            EndText();
        }
    }
}