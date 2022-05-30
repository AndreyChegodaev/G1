using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    [SerializeField] GameObject[] popups;
    [SerializeField] GameObject[] credits;

    void Start()
    {
        foreach (GameObject credit in credits)
        {
            credit.SetActive(true);
        }

        if (SaveManager.instance.activeSave.settings_WelcomePopUp == true)
        {
            foreach (GameObject popup in popups)
            {
                popup.SetActive(true);
            }
        }



    }
}
