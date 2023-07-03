using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    public Animator door;
    [SerializeField] bool doorCanOpen = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(doorCanOpen == true && other.CompareTag("Player"))
        {
            door.SetBool("dooropen", true);
        }
        

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        door.SetBool("dooropen", false);
    }
    public void DoorOpen()
    {
        doorCanOpen = true;
    }
}
