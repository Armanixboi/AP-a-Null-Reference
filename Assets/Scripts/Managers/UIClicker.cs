using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIClicker : MonoBehaviour
{
    public Animator buttonClicker;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClicked()
    {
        buttonClicker.SetBool("clicked", true);
        Invoke("FalseAgain", 0.1f);
    }
    public void FalseAgain()
    {
        buttonClicker.SetBool("clicked", false);
    }
}
