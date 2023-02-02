using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeIn_PF5T : MonoBehaviour
{
    public string sceneName;
    public float timer = 2;
    public GameObject fadeIn;



    public void FadeIn()
    {
        fadeIn.GetComponent<Animator>().SetBool("FadeIn", true);
        Invoke("LoadScene", timer);
    }


    public void LoadScene()
    {
        SaveManager.instance.Save();
        SceneManager.LoadScene(sceneName);

        SaveManager.instance.activeSave.currentLevel = sceneName;
    }
}

