using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunActivator : MonoBehaviour
{
    public List<GameObject> activatingObject = new List<GameObject>();
    public List<GameObject> deactivatingObject = new List<GameObject>();
    public List <Gun> activatingShooting  = new List<Gun>();
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ActivateObjects();
        }
        
    }
    void ActivateObjects()
    {
        foreach (GameObject obj in activatingObject)
        {
            obj.SetActive(true);
        }
        foreach (GameObject obj in deactivatingObject)
        {
            obj.SetActive(false);
        }
        foreach (Gun obj in activatingShooting) 
        {
            obj.enabled = true;
        }

    }
}
