using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class DialogueManager : MonoBehaviour
{
    public bool playerIsClose;
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI npcName;
    public Image npcImage;
    public List<string> dialogue;
    private int index;
    public GameObject nextButton;
    public float wordSpeed;
    public NPC npcScript;



    private void Start()
    {
        
        npcScript = this.GetComponent<NPC>();
        dialogue = new List<string>();
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space) && playerIsClose)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                EndText();
            }
            else
            {
                dialogue = npcScript.npcdialogue;
                npcImage.sprite = npcScript.npcDialogueImage.sprite;
                npcName.text = npcScript.npcDialogueName;

                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        if (dialogue.Count > 0 && dialogueText.text == dialogue[index])
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
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextDialogue()
    {
        Debug.Log("Running");
        nextButton.SetActive(false);

        if (index < dialogue.Count - 1)
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

    

}
