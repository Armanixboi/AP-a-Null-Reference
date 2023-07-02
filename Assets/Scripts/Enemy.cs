using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public HealthSystem health;
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
        if(collision.gameObject.name == "Bullet")
        {
            //Destroy(this.gameObject);
            health.Damage();
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
        }
    }
}
