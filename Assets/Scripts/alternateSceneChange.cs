using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;


public class alternateSceneChange : MonoBehaviour
{
    [SerializeField] Camera mainCam;
    [SerializeField] PostProcessVolume vol;
    Vignette vign;
    [SerializeField] float effectLimit;
    [SerializeField] GameObject detective;
    [SerializeField] DialogueManager endDialogue;
    // Start is called before the first frame update
    void Start()
    {
        vign = vol.profile.GetSetting<Vignette>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vign.intensity.value >= effectLimit)
        {
            SceneManager.LoadScene("EndCredits4");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Detective - Sasa" && endDialogue.dialogue.Count == 0)
        {

            SceneManager.LoadScene("EndCredits3");
            Debug.Log("Next Scene");



            //}
        }
    }

}