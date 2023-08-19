using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public bool canEndIt;
    public Animator startWorkingUI;
    public playerMovement playerMovementScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canEndIt == true)
        {
            startWorkingUI.SetBool("canpickup", true);
        }
        if (canEndIt == false)
        {
            startWorkingUI.SetBool("canpickup", false);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerMovementScript.canShoot = false;
            canEndIt = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerMovementScript.canShoot = true;
            canEndIt = false;
        }
    }
}
