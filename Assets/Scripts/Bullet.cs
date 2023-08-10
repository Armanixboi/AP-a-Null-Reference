using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float timer;
    public HealthSystem health;
    public float damage = 1f;
    public ParticleSystem bulletFeed;


    // Start is called before the first frame update


    void Start()
    {
        bulletFeed.Play();
        Destroy(this.gameObject, timer);
    }

    // Update is called once per frame
    void Update()
    {

        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //Physics2D.IgnoreCollision(player.GetComponent<CapsuleCollider2D>(), GetComponent<CapsuleCollider2D>());
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      /*  if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("HIT");
            //Destroy(collision.gameObject);   
            //Destroy(this.gameObject);
            health.Damage();
            
        }*/
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("HIT");
            //Destroy(collision.gameObject);   
            //Destroy(this.gameObject);
            health.Damage();

        }
    }
}
