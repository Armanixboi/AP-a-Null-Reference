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
    // Start is called before the first frame update
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPref, startPoint.position, startPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
    }
    // Update is called once per frame
    private void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
        Vector2 aiming = mousePos - rb.position;
        float aimAngle = Mathf.Atan2(aiming.y, aiming.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
}
