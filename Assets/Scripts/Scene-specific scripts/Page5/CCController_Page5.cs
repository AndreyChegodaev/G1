using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCController_Page5 : MonoBehaviour
{
    public List<GameObject> lines = new List<GameObject>();

    void Start()
    {
        if (SaveManager.instance.activeSave.dejaVu == 1)
        {
            Destroy(lines[0]);
            Destroy(lines[2]);
        }

        else if (SaveManager.instance.activeSave.dejaVu > 1)
        {
            Destroy(lines[0]);
            Destroy(lines[1]);
        }

        else
        {
            Destroy(lines[1]);
            Destroy(lines[2]);
        }
    }

    // Update is called once per frame

}
