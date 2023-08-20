using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCreditsChecker3 : MonoBehaviour
{
    [SerializeField] bool entered;
    public bool canEnd;
    [SerializeField] GameObject goToEndCreditsScene3;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && entered)
        {
            canEnd = true;
            goToEndCreditsScene3.SetActive(true);
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
