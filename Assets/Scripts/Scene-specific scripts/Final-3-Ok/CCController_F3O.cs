using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCController_F3O : MonoBehaviour
{
    public static CCController_F3O instance;
    
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
            lines[1] = null;
        }
        else lines[0] = null;

        if (SaveManager.instance.activeSave.hasFinger == true)
        {
            lines[3] = null;
        }
        else lines[2] = null;

        if (SaveManager.instance.activeSave.hasFork == true)
        {
            lines[5] = null;
        }
        else lines[4] = null;

        if (SaveManager.instance.activeSave.dejaVu != 0)
        {
            lines[7] = null;
        }
        else lines[6] = null;

        if (SaveManager.instance.activeSave.visitedWitch == true)
        {
            lines[9] = null;
        }
        else lines[8] = null;

        if (SaveManager.instance.activeSave.crossedRavine == true)
        {
            lines[11] = null;
        }
        else lines[10] = null;


        if (SaveManager.instance.activeSave.crossedRavine == true && SaveManager.instance.activeSave.waitAtTheDoor >= 4)
        {
            lines[12] = null;
            lines[14] = null;
        }
        else if (SaveManager.instance.activeSave.crossedRavine == true && SaveManager.instance.activeSave.waitAtTheDoor < 4)
        {
            lines[13] = null;
            lines[14] = null;
        }
        else if (SaveManager.instance.activeSave.crossedRavine == false)
        {
            lines[12] = null;
            lines[13] = null;
        }

        if (SaveManager.instance.activeSave.keptTheRing == true)
        {
            lines[16] = null;
        }
        else lines[15] = null;

        lines.RemoveAll(item => item == null);
    }

    public void ShowLine()
    {
        currentLine++;
        lines[currentLine].SetActive(true);
    }

}
