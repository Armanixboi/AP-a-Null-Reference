using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public HealthSystem health;
    Vector3 lerpTest;
    Vector3 initialColour;
    Color initialColourTest;
    // Start is called before the first frame update
    void Start()
    {
        initialColourTest = this.gameObject.GetComponent<SpriteRenderer>().color;

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
            Debug.Log("Collisiobn");
            health.Damage();
            Update();
           
            //Destroy(this.gameObject);
        }
    }
}
