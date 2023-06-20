using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    Vector2 mousePos;
    Vector2 moveDir;

    public GameObject bulletPrefab;
    public Transform startPoint;
    public float bulletSpeed;
    public Animator panimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        panimator.SetFloat("Horizontal", moveX);
        panimator.SetFloat("Vertical", moveY);
        panimator.SetFloat("Speed", moveDir.sqrMagnitude);

        moveDir = new Vector2(moveX, moveY).normalized;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, startPoint.position, startPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDir.x * speed, moveDir.y * speed);
        //Vector2 aiming = mousePos - rb.position;
    }
}
