using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CCManager_F5T : MonoBehaviour

{
    public static CCManager_F5T instance;


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
            CCController_F5T.instance.ShowLine();
            if (CCController_F5T.instance.currentLine > 0)
                CCController_F5T.instance.lines[CCController_F5T.instance.currentLine-1].SetActive(false);
        }
    }
}
