using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Guard")
        {
            Debug.Log("HIT");
            Destroy(collision.gameObject);
        }
        else
        {
            Destroy(this.gameObject, timer);
        }
        
    }
}
