using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float timer;
    public HealthSystem health;
    public float damage = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, timer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("HIT");
            //Destroy(collision.gameObject);   
            health.Damage();
        }
        
        
    }
}
