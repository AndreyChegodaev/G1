using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CCManager_F3O : MonoBehaviour

{
    public static CCManager_F3O instance;


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
            CCController_F3O.instance.ShowLine();
            if (CCController_F3O.instance.currentLine > 0)
            CCController_F3O.instance.lines[CCController_F3O.instance.currentLine-1].SetActive(false);
        }
    }
}
