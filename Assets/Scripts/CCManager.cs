using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CCManager : MonoBehaviour

{
    public static CCManager instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        if (SaveManager.instance.activeSave.settings_CCSwitch == true)
        instance.gameObject.SetActive(true);
    }

    public void Hide()
    {
        if (SaveManager.instance.activeSave.settings_CCSwitch == true)
            instance.gameObject.SetActive(false);
    }
}
