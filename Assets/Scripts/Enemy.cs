using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class Enemy : MonoBehaviour
{
    public HealthSystem health;
    Vector3 lerpTest;
    Vector3 initialColour;
    Color initialColourTest;
    SpriteRenderer sprite;
    public Animator gettingShot;
    [SerializeField] PostProcessVolume volume;
    bool increase;
    float minSpeed;
    float maxSpeed;
    float speed;
    Vignette vig;
    
    // Start is called before the first frame update
    void Start()
    {
        //initialColourTest = this.gameObject.GetComponent<SpriteRenderer>().color;
        sprite = GetComponent<SpriteRenderer>();
        vig = volume.profile.GetSetting<Vignette>();

    }
    // Update is called once per frame
   

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Collision");
            health.Damage();
            sprite.color = new Color(1,0,0,0.5f);
            gettingShot.SetBool("ifShot", true);
            increase = true;
            //vig.intensity.value += speed * Time.deltaTime;
            //vig.intensity.value += .2f;
            //Destroy(this.gameObject);
        }

        if(health.currentHealth <= 0f)
        {
            Destroy(this.gameObject);
        }
       
    }

    void Update()
    {
        //lerpTest = Vector3.Lerp(, , 1)
        //gameObject.GetComponent<SpriteRenderer>().ler .color += new Color(0, 0, 0, 1);
        //volume.profile.TryGetSettings(out vig);
        if(increase)
        {
            vig.intensity.value += speed * Time.deltaTime;
            vig.intensity.value = Mathf.Clamp(vig.intensity.value, minSpeed, maxSpeed);
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            gettingShot.SetBool("ifShot", false);
        }
    }
}
