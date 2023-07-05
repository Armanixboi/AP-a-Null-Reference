using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueManager : MonoBehaviour
{
    public GameObject[] Dialogues; //Array of game objects
    public NPC npc;

    private void Update()
    {
        if(npc.playerIsClose == true)
        {
             
            npc.playThisDialogue = true;
        }
    }
    // The dialogue manager has an array of game objects, these game objects should be each be an NPC with dialogues.
    // When the player is in range of one of the game objects, access that gameobjects NPC script and enable playThisDialogue = true
    // WHen the player is out of range, then turn this off.
}
