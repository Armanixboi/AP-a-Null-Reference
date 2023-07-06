using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public HealthSystem health;
    Vector3 lerpTest;
    Vector3 initialColour;
    Color initialColourTest;
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        //initialColourTest = this.gameObject.GetComponent<SpriteRenderer>().color;
        sprite = GetComponent<SpriteRenderer>();

    }
    // Update is called once per frame
    void Update()
    {
        //lerpTest = Vector3.Lerp(, , 1)
        //gameObject.GetComponent<SpriteRenderer>().ler .color += new Color(0, 0, 0, 1);
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Collision");
            health.Damage();
            sprite.color = new Color(1,0,0,0.5f);

            //Destroy(this.gameObject);
        }
    }
}
