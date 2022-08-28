using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro_toggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SaveManager.instance.activeSave.settings_FullIntro == true)
            gameObject.GetComponent<Toggle>().isOn = true;
        else gameObject.GetComponent<Toggle>().isOn = false;
    }

}
