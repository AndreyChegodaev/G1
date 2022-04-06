using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CCManager_F4G : MonoBehaviour

{
    public static CCManager_F4G instance;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        gameObject.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        if (SaveManager.instance.activeSave.settings_CCSwitch == true)
        {
            gameObject.GetComponent<Image>().enabled = true;
            CCController_F4G.instance.ShowLine();
            if (CCController_F4G.instance.currentLine > 0)
            CCController_F4G.instance.lines[CCController_F4G.instance.currentLine-1].SetActive(false);
        }
    }
}
