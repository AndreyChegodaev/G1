using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCController_F5T : MonoBehaviour
{
    public static CCController_F5T instance;
    
    public List<GameObject> lines = new List<GameObject>();
    public int currentLine = -1;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if (SaveManager.instance.activeSave.heardVoice == true)
        {
            lines[1] = null;
        }
        else lines[2] = null;

        lines.RemoveAll(item => item == null);
    }

    public void ShowLine()
    {
        currentLine++;
        lines[currentLine].SetActive(true);
    }

}
