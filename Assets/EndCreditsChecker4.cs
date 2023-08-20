using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCreditsChecker4 : MonoBehaviour
{
    [SerializeField] bool entered;
    public bool canEnd;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            canEnd = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            entered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            entered = false;
        }
    }

}
