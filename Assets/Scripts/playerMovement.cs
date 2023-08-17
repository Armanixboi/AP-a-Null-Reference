using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    public Text ammoCounter;
    public float ammo = 0f;
    public float speed;
    public Rigidbody2D rb;
    public GunActivator gunActivatorScript1;
    public GunActivator gunActivatorScript2;
    // public bool canPickUpAmmo;
    //Vector2 mousePos;
    Vector2 moveDir;
    public Gun gun;
    //public HealthSystem health;
    public Animator spaceToPickUp1;
    public Animator panimator;
    public AudioSource gunShotSFX;
    public bool canShoot;

   
    void Update()
    {
        
        if (canShoot)
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
        }

        if (gunActivatorScript1.canPickUpGun == true)
        {
            spaceToPickUp1.SetBool("canpickup", true);
        }
        if (gunActivatorScript1.canPickUpGun == false )
        {
            spaceToPickUp1.SetBool("canpickup",false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && gunActivatorScript1.canPickUpGun)
        {
            PickedUpGun();
        }

        if (Input.GetKeyDown(KeyCode.Space) && gunActivatorScript2.canPickUpGun)
        {
            PickedUpLevel2Ammo();
        }


        if (Input.GetMouseButtonDown(0) && ammo > 0f && canShoot)
        {
            Vector2 mousePosition = Input.mousePosition;
            Vector2 screen = new Vector2(Screen.width, Screen.height);
            mousePosition.x /= screen.x;
            mousePosition.y /= screen.y;

            if (!(mousePosition.x < 0.0793 && mousePosition.y > 0.872)  && !(mousePosition.x > 0.9 && mousePosition.y > 0.872))
            {
                gun.Shoot();
                ammo -= 1f;
                gunShotSFX.Play();
            }
            
        }

        ammoCounter.text = ammo.ToString();
    }

    public void PickedUpAmmo()
    {
        ammo += 1f;
    }
  
    public void PickedUpGun()
    {
        gunActivatorScript1.ActivateObjects();
        panimator.SetBool("ifPickedUpGun", true);
    }

    public void PickedUpLevel2Ammo()
    {
        gunActivatorScript2.ActivateObjects();
    }


    void FixedUpdate()
    {
        /*Vector2 aiming = mousePos - rb.position;
        float aimAngle = Mathf.Atan2(aiming.y, aiming.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;*/
    }
}
