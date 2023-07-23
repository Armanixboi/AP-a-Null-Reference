using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barricadeOpen : MonoBehaviour
{
    //public GameObject p1;
    //public GameObject p2;
    public HealthSystem npchealth1;
    public HealthSystem npchealth2;
    public HealthSystem doorHealth;
    public Door1 doorScript;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (npchealth1.currentHealth <= 0f && npchealth2.currentHealth <= 0f || doorHealth.currentHealth <= 0f)
        {
            doorScript.doorCanOpen = true;
            Destroy(this.gameObject);
        }


    }
}
