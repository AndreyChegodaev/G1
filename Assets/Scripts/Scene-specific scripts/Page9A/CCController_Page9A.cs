using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCController_Page9A : MonoBehaviour
{
    public List<GameObject> lines = new List<GameObject>();

    void Start()
    {
        if (SaveManager.instance.activeSave.waitAtTheDoor <= 1)
        {
            Destroy(lines[1]);
            Destroy(lines[2]);
            Destroy(lines[3]);
        }

        else if (SaveManager.instance.activeSave.waitAtTheDoor == 2)
        {
            Destroy(lines[0]);
            Destroy(lines[2]);
            Destroy(lines[3]);
        }

        else if (SaveManager.instance.activeSave.waitAtTheDoor == 3)
        {
            Destroy(lines[0]);
            Destroy(lines[1]);
            Destroy(lines[3]);
        }
        else
        {
            Destroy(lines[0]);
            Destroy(lines[1]);
            Destroy(lines[2]);
        }
    }

    // Update is called once per frame

}
