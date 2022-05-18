using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCController_F1B : MonoBehaviour
{
    public static CCController_F1B instance;
    
    public List<GameObject> lines = new List<GameObject>();
    public int currentLine = -1;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if (SaveManager.instance.activeSave.hasFinger == true)
        {
            lines[2] = null;
        }
        else
        {
            lines[1] = null;
        }

        if (SaveManager.instance.activeSave.hasFork == true)
        {
            lines[4] = null;
        }
        else
        {
            lines[3] = null;
        }

        if (SaveManager.instance.activeSave.dejaVu != 0)
        {
            lines[6] = null;
        }
        else
        {
            lines[5] = null;
        }

        if (SaveManager.instance.activeSave.visitedWitch == true)
        {
            lines[8] = null;
        }
        else
        {
            lines[7] = null;
        }

        if (SaveManager.instance.activeSave.killedByWitch == true)
        {
            lines[10] = null;
        }
        else
        {
            lines[9] = null;
        }

        if (SaveManager.instance.activeSave.firstPlaytrough == false)
        {
            lines[11] = null;
        }

        lines.RemoveAll(item => item == null);
    }

    public void ShowLine()
    {
        currentLine++;
        lines[currentLine].SetActive(true);
    }

}
