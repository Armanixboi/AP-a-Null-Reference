using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogues : MonoBehaviour
{
    [SerializeField]
    private string[] sentences;
    

    public GameObject[] answers;
    public TextMeshProUGUI dialogueText;
    void Start()
    {
        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(true);
        }
    }

    
    void Update()
    {
        
    }
    public void DialogueOption()
    {
        dialogueText.gameObject.SetActive(true);
        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(false);
        }
        dialogueText.text = (sentences[0]);
    }
}
