using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class PageTurnerForDialog_Page6 : MonoBehaviour
{
    public static PageTurnerForDialog_Page6 instance;
    
    public int timer;
    public Image curtain;
    public GameObject turningPageAnimation;
    public string sceneName;
    public string sceneNameAlt;
    public Camera illustrationCamera;


    public void Awake()
    {
        instance = this;
    }

    public void TaskOnClick()
    {
        StartCoroutine(CurtainFadeIn());
        if (SaveManager.instance.activeSave.hasFinger == true)
        {
            SaveManager.instance.activeSave.currentLevel = sceneName;
        }
        else SaveManager.instance.activeSave.currentLevel = sceneNameAlt;
       
        
        SaveManager.instance.Save();      
    }

    IEnumerator CurtainFadeIn()
    {
        curtain.CrossFadeAlpha(1f, timer, false);
        yield return new WaitForSeconds(timer);

        illustrationCamera.enabled = false;

        StartCoroutine(TurnPageAnimation());       
    }

    IEnumerator TurnPageAnimation()
    {
        turningPageAnimation.SetActive(true);
        yield return new WaitForSeconds(timer-1);
       if (SaveManager.instance.activeSave.hasFinger == true)
        {
            SceneManager.LoadScene(sceneName);
        }
       else SceneManager.LoadScene(sceneNameAlt);



    }
}
