using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public bool canPickUpAmmo;
    public Animator ammo;
    public Animator ammoPickUpUI;
    public playerMovement playerMovementScript;


    public void Update()
    {
        if (canPickUpAmmo == true)
        {
            ammoPickUpUI.SetBool("canpickup", true);
        }
        if (canPickUpAmmo == false)
        {
            ammoPickUpUI.SetBool("canpickup", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && canPickUpAmmo)
        {
            
            playerMovementScript.PickedUpAmmo();
            DestroyAmmo();
            
        }

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canPickUpAmmo = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canPickUpAmmo = false;
        }
    }
    public void DestroyAmmo()
    {
        ammoPickUpUI.SetBool("canpickup", false);
        Destroy(gameObject);
    }
}
