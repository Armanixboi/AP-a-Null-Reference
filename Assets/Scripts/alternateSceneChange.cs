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
    [SerializeField] DialogueManager dialogueManagerScript;
    //[SerializeField] EndCreditsChecker4 endCreditsChecker4Script;
    [SerializeField] string endCredits4Scene;
    //[SerializeField] string endCredits3Scene;


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
            SceneManager.LoadScene(endCredits4Scene);
        }
    }

   /* private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Detective - Sasa" &&  dialogueManagerScript.endIt == true && endCreditsChecker4Script.canEnd == true)
        {

            SceneManager.LoadScene(endCredits3Scene);
            Debug.Log("Next Scene");



            //}
        }
    }*/

}