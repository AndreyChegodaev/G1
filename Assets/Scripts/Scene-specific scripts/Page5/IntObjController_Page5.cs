using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntObjController_Page5 : MonoBehaviour
{
    public GameObject optionV1;
    public GameObject optionV2;

    void Start()
    {
        optionV1.transform.position = optionV2.transform.position;
        Conditions();
    }

    void Conditions()
    {
        if (SaveManager.instance.activeSave.firstPlaytrough == true)
        {
            optionV2.SetActive(false);
        }
        else
        {
            optionV1.SetActive(false);
        }
    }
}
