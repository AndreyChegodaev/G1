using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCController_Page5v2 : MonoBehaviour
{
    public List<GameObject> lines = new List<GameObject>();

    void Start()
    {
        if (SaveManager.instance.activeSave.hasFinger == false)
        {
            Destroy(lines[1]);
        }

        else Destroy(lines[0]);
    }

    // Update is called once per frame

}
