using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class PageTurner : MonoBehaviour
{
    public static PageTurner instance;
    
    public int timer;
    public Image curtain;
    public GameObject turningPageAnimation;
    public string sceneName;
    public Camera illustrationCamera;


    public void Awake()
    {
        instance = this;
    }

    public void TaskOnClick()
    {
        StartCoroutine(CurtainFadeIn());
        SaveManager.instance.activeSave.currentLevel = sceneName;
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
        SceneManager.LoadScene(sceneName);


    }
}
