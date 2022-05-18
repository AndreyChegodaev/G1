using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CCManager_PF1B : MonoBehaviour

{
    public static CCManager_PF1B instance;
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
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (AudioManager_PF1B.instance.currentTrack == AudioManager_PF1B.instance.audioClips.Count - 2)
        {
            if (SaveManager.instance.activeSave.hasFinger == true)
                lineToShow = gameObject.transform.GetChild(1).gameObject;
            else lineToShow = gameObject.transform.GetChild(0).gameObject;
        }
        else if (AudioManager_PF1B.instance.currentTrack == AudioManager_PF1B.instance.audioClips.Count - 1 && SaveManager.instance.activeSave.hasFork == true)
        {
            lineToShow = gameObject.transform.GetChild(2).gameObject;
            StartCoroutine(TimedShow());
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

    IEnumerator TimedShow()
    {
        yield return new WaitForSeconds(11.0f);
        Show();
    }
}
