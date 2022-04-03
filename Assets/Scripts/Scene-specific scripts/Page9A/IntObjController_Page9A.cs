using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntObjController_Page9A : MonoBehaviour
{
    public GameObject door;
    public GameObject bushes;
    public GameObject doormat;
    public GameObject man;

    void Start()
    {
        man.SetActive(false);
        Conditions();
    }

    void Conditions()
    {
        if (SaveManager.instance.activeSave.hasFinger == false)
        {
            bushes.SetActive(false);
            doormat.SetActive(false);
        }

        if (SaveManager.instance.activeSave.waitAtTheDoor > 3)
        {
            door.SetActive(false);
            man.SetActive(true);
            bushes.SetActive(false);
            doormat.SetActive(false);
        }
    }
}
