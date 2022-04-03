using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCController_Page9C : MonoBehaviour
{
    public List<GameObject> lines = new List<GameObject>();

    void Start()
    {
        if (SaveManager.instance.activeSave.heardVoice == true)
        {
            Destroy(lines[1]);
        }

        else Destroy(lines[0]);
    }

    // Update is called once per frame

}
