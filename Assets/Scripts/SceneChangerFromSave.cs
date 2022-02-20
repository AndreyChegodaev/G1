using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerFromSave : MonoBehaviour
{
public void LoadScene()
    {
        SceneManager.LoadScene(SaveManager.instance.activeSave.currentLevel);
    }
}
