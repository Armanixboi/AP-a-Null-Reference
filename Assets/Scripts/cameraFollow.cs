using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    float cameraSpeed = 0.25f;
    Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 newPosition = new Vector3(target.position.x, target.position.y, -10f);
        Vector3 newPosition = new Vector3(0, 0, -10f);
        Vector3 targetPosition = target.position + newPosition;
        //transform.position = Vector3.Slerp (transform.position, newPosition, cameraSpeed * Time.deltaTime);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition , ref velocity, cameraSpeed);
    }
}
