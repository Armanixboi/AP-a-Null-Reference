using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class DialogueManager : MonoBehaviour
{
    public GameObject[] dialoguesALL; //Array of NPCS
    public string[] currentDialogue;

    int currentDialogIndex;


    //Legacy
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText; //replace this with the current active speaker
    public TextMeshProUGUI Name;
    public Image npcImage;
    public Image npcDialogueImage;
    public string npcName;
    //public string[] currentDialogue;
    private int index;
    public GameObject nextButton;
    public float wordSpeed;
    public bool playerIsClose;
    public bool playThisDialogue;

    private void Start()
    {
        currentDialogIndex = 0;
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
                npcDialogueImage.sprite = npcImage.sprite;
                Name.text = npcName;
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        if (dialogueText.text == currentDialogue[index])
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
        foreach (char letter in currentDialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextDialogue()
    {
        Debug.Log("Running");
        nextButton.SetActive(false);

        if (index < currentDialogue.Length - 1)
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

    public void WhichDialogueIsActive()
    {
        Debug.Log("WhichDialogueIsActive");
        for (int i = 0; i < dialoguesALL.Length; i++)
        {
            if (dialoguesALL[i].activeSelf == true)
            {
                dialoguesALL[i].GetComponent<NPC>().dialogue = currentDialogue;
                Debug.Log(currentDialogue);
            }
        }
    
    }
}
