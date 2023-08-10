using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPref;
    public Transform startPoint;
    public float bulletSpeed;
    public Rigidbody2D rb;
    Vector2 mousePos;
    public Camera cam;


    private Collider2D player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
        Debug.Log(player + "dsaaaaaaaaaaaa");
    }

    public void Shoot()
    {
        Vector2 offset = (Vector2)transform.position - mousePos;
        GameObject bullet = Instantiate(bulletPref, (Vector2)transform.position - offset.normalized, startPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;

    }
    private void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 aiming = mousePos - new Vector2(transform.position.x, transform.position.y);
        //float aimAngle = Mathf.Atan2(aiming.y, aiming.x) * Mathf.Rad2Deg - 90f;


        // Debug.Log(mousePos);
        //rb.rotation = aimAngle;
        //

        transform.up = aiming;
    }

    void FixedUpdate()
    {
       
       // Quaternion rotation = Quaternion.LookRotation(mousePos, Vector2.up);
        //transform.rotation = rotation;
    }
}
