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
    [SerializeField] SpriteRenderer sprite;
    //[SerializeField] Animator gettingShot;
    [SerializeField] PostProcessVolume volume;
    [SerializeField] bool increase;
    [SerializeField] float minSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float speed;
    Vignette vig;
    float currentValue;
    float timer;
    
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
            currentValue = vig.intensity.value;
            increase = true;
            health.Damage();
            sprite.color = new Color(1,0,0,0.5f);
            //gettingShot.SetBool("ifShot", true);
            Debug.Log(vig.intensity.value);
            
            //vig.intensity.value += speed * Time.deltaTime;
            //vig.intensity.value += .2f;
            //Destroy(this.gameObject);
        }

        if(health.currentHealth <= 0f /*&& gettingShot == true*/)
        {
            increase = true;
            //Destroy(this.gameObject);
        }
       
    }

    void Update()
    {
        if(increase)
        {
            timer += Time.deltaTime;
            vig.intensity.value = Mathf.Lerp(currentValue, maxSpeed + currentValue, timer/speed);
            if (vig.intensity.value >= maxSpeed + currentValue && health.currentHealth <= 0f)
            {
                increase = false;
                Destroy(gameObject);
            }
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            //gettingShot.SetBool("ifShot", false);
            //Destroy(this.gameObject);
        }
    }
}
