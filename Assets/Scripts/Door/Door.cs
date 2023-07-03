using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator door;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        door.SetBool("dooropen", true);

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        door.SetBool("dooropen", false);
    }
   
}
