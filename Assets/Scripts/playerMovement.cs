using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float ammo = 0f;
    public float speed;
    public Rigidbody2D rb;
    //Vector2 mousePos;
    Vector2 moveDir;
    public Gun gun;
    //public HealthSystem health;

    public Animator panimator;
    //public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    void Update()
    {
        //Movement
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        //Animation
       panimator.SetFloat("Horizontal", moveX);
       panimator.SetFloat("Vertical", moveY);
       panimator.SetFloat("Speed", moveDir.sqrMagnitude);

        moveDir = new Vector2(moveX, moveY).normalized;
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && ammo > 0f)
        {
            gun.Shoot();
            ammo -= 1f;
        }
        rb.velocity = new Vector2(moveDir.x * speed, moveDir.y * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ammo")
        {
            ammo += 1f;
            Destroy(collision.gameObject);
        }
    }

    void FixedUpdate()
    {
        /*Vector2 aiming = mousePos - rb.position;
        float aimAngle = Mathf.Atan2(aiming.y, aiming.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;*/
    }
}
