using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CCManager_Page9B : MonoBehaviour

{
    public static CCManager_Page9B instance;
    private GameObject lineToShow;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        gameObject.GetComponent<Image>().enabled = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (AudioManager_Page9B.instance.currentTrack == 0)
        {
            lineToShow = gameObject.transform.GetChild(0).gameObject;
        } 
        else if (AudioManager_Page9B.instance.currentTrack == 1)
        {
            lineToShow = gameObject.transform.GetChild(1).gameObject;
        }

    }

    public void Show()
    {
        if (SaveManager.instance.activeSave.settings_CCSwitch == true)
        {
            gameObject.GetComponent<Image>().enabled = true;
            lineToShow.gameObject.SetActive(true);
        }

    }

    public void Hide()
    {
        if (SaveManager.instance.activeSave.settings_CCSwitch == true)
        {
            gameObject.GetComponent<Image>().enabled = false;
            lineToShow.gameObject.SetActive(false);
        }
            
    }
}
