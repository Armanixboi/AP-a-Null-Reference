using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogues : MonoBehaviour
{
    [SerializeField]
    private string[] sentences;
    public GameObject[] answers;
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
}
