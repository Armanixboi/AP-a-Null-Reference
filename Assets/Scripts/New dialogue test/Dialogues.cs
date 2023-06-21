using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogues : MonoBehaviour
{
    [SerializeField]
    private string[] sentences1;
    [SerializeField]
    private string[] sentences2;

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
    public void DialogueOption1()
    {
        dialogueText.gameObject.SetActive(true);
        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(false);
        }
        dialogueText.text = (sentences1[0]);
    }
    public void DialogueOption2()
    {
        dialogueText.gameObject.SetActive(true);
        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(false);
        }
        dialogueText.text = (sentences2[0]);
    }
}
