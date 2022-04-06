using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCController_F4G : MonoBehaviour
{
    public static CCController_F4G instance;
    
    public List<GameObject> lines = new List<GameObject>();
    public int currentLine = -1;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if (SaveManager.instance.activeSave.dejaVu != 0)
        {
            lines[4] = null;
        }

        else lines[3] = null;

        lines.RemoveAll(item => item == null);
    }

    public void ShowLine()
    {
        currentLine++;
        lines[currentLine].SetActive(true);
    }

}
