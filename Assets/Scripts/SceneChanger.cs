using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
public void LoadScene(string sceneName)
    {
        SaveManager.instance.Save();
        SceneManager.LoadScene(sceneName);
       
        SaveManager.instance.activeSave.currentLevel = sceneName;
    }
}
