using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barricadeOpen : MonoBehaviour
{
    //public GameObject p1;
    //public GameObject p2;
    public HealthSystem npchealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(npchealth.currentHealth <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
