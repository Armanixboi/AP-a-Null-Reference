using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class UIHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
     public playerMovement playerMovementScript;
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor Entering " + name + " GameObject");
        playerMovementScript.canShoot = false;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        playerMovementScript.canShoot = true;
    }

}
