using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntObjController_Page8 : MonoBehaviour
{
    public GameObject bushes;
    public GameObject doormat;

    void Start()
    {
        Conditions();
    }

    void Conditions()
    {
        if (SaveManager.instance.activeSave.hasFinger == false)
        {
            bushes.SetActive(false);
            doormat.SetActive(false);
        }
    }
}
