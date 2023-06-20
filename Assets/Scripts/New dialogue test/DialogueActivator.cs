using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivator : MonoBehaviour
{
    [SerializeField]
    private GameObject dialogueManager;
    private bool canTalk;
    void Start()
    {

    }
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canTalk)
        {
            dialogueManager.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canTalk = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canTalk = false;
            
        }
    }
}
