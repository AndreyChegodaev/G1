using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenuManager : MonoBehaviour
{
    [SerializeField] Button musicButton;
    [SerializeField] Sprite music_on;
    [SerializeField] Sprite music_off;

    [SerializeField] Button voiceButton;
    [SerializeField] Sprite voice_on;
    [SerializeField] Sprite voice_off;

    [SerializeField] Button cCButton;
    [SerializeField] Sprite cC_on;
    [SerializeField] Sprite cC_off;


    // Update is called once per frame
    void Update()
    {
        if (SaveManager.instance.activeSave.settings_MusicSwitch == true)
        {
            musicButton.GetComponent<Image>().sprite = music_on;
        }

        else 
        {
            musicButton.GetComponent<Image>().sprite = music_off;
        }

        if (SaveManager.instance.activeSave.settings_VoiceSwitch == true)
        {
            voiceButton.GetComponent<Image>().sprite = voice_on;
        }

        else 
        {
            voiceButton.GetComponent<Image>().sprite = voice_off;
        }

        if (SaveManager.instance.activeSave.settings_CCSwitch == true)
        {
            cCButton.GetComponent<Image>().sprite = cC_on;
        }

        else 
        {
            cCButton.GetComponent<Image>().sprite = cC_off;
        }
    }
}
