using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour
{
    NPC npcScript;
    public bool playerisclose;
    DialogueManager dialogueManager;

    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI Name;
    public Image npcImage;
    public Image npcDialogueImage;
    public string npcName;
    public string[] dialogue;
    private int index;
    public GameObject nextButton;
    public float wordSpeed;
    public bool playerIsClose;
    public bool playThisDialogue;


    private void Start()
    {
        npcScript = this.GetComponent<NPC>();
        dialogueManager = FindAnyObjectByType<DialogueManager>();
    }

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
                npcDialogueImage.sprite = npcImage.sprite;
                Name.text = npcName;
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
       
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
            Debug.Log("Running");
            nextButton.SetActive(false);

            if (index < dialogue.Length - 1)
            {
                index++;
                dialogueText.text = "";
                StartCoroutine(Typing());
            }
            else
            {
                EndText();
                playThisDialogue = false;
            }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerisclose = true;
            dialogueManager.WhichDialogueIsActive();
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
