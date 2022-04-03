using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCController_PF1B : MonoBehaviour
{
    public List<GameObject> lines = new List<GameObject>();

    void Start()
    {
        if (SaveManager.instance.activeSave.hasFinger == true)
        {
            Destroy(lines[0]);
        }
        else Destroy(lines[1]);
    }

    // Update is called once per frame

}
