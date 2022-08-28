using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SaveManager.instance.activeSave.settings_FullIntro == true)
        {
            SceneManager.LoadScene("0Intro");
        }
        else SceneManager.LoadScene("1Intro");
    }


}
