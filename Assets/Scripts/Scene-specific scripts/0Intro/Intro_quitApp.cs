using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_quitApp : MonoBehaviour
{
    private void Start()
    {
        
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    private void OnApplicationQuit()
    {

        SaveManager.instance.Save();
    }
}
