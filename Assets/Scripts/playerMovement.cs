using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float ammo = 0f;
    public float speed;
    public Rigidbody2D rb;
    public Ammo ammoScript;
   // public bool canPickUpAmmo;
    //Vector2 mousePos;
    Vector2 moveDir;
    public Gun gun;
    //public HealthSystem health;
    public Animator spaceToPickUp;
    public Animator panimator;

    //public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        ammoScript = FindAnyObjectByType<Ammo>(); 
    }

    // Update is called once per frame
   
    void Update()
    {
        //Movement
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(moveDir.x * speed, moveDir.y * speed);
        //Animation
       panimator.SetFloat("Horizontal", moveX);
       panimator.SetFloat("Vertical", moveY);
       panimator.SetFloat("Speed", moveDir.sqrMagnitude);

        moveDir = new Vector2(moveX, moveY).normalized;
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if(ammoScript.canPickUpAmmo == true)
        {
            spaceToPickUp.SetBool("canpickup",true);
        }
        if(ammoScript.canPickUpAmmo == false)
        {
            spaceToPickUp.SetBool("canpickup",false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && ammoScript.canPickUpAmmo)
        {
            PickedUpAmmo();
            panimator.SetBool("ifPickedUpGun",true);
        }
        
        if (Input.GetMouseButtonDown(0) && ammo > 0f)
        {
            gun.Shoot();
            ammo -= 1f;
        }
        
    }

    public void PickedUpAmmo()
    {
        ammo += 1f;
        ammoScript.DestroyAmmo();
    }
  
    void FixedUpdate()
    {
        /*Vector2 aiming = mousePos - rb.position;
        float aimAngle = Mathf.Atan2(aiming.y, aiming.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;*/
    }
}
