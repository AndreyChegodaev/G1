using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CCManager_finals : MonoBehaviour

{
    public static CCManager_finals instance;

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
            CCController_F1B.instance.ShowLine();
            if (CCController_F1B.instance.currentLine > 0)
            CCController_F1B.instance.lines[CCController_F1B.instance.currentLine-1].SetActive(false);
        }
    }
}
