using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager instance;
    
    [SerializeField]
    Button buttonStart;
    [SerializeField]
    Button buttonContinue;
    [SerializeField]
    Button buttonWipe;
    [SerializeField]
    Button buttonDiary;
    [SerializeField]
    Text unlockText;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        buttonWipe.onClick.AddListener(RestartStartButton);


        if (SaveManager.instance.activeSave.fakeEnding == false && SaveManager.instance.activeSave.trueEnding == false)
        {
            buttonDiary.gameObject.SetActive(false);
            unlockText.gameObject.SetActive(false);
        }
        if (SaveManager.instance.activeSave.fakeEnding == true)
        {
            buttonDiary.gameObject.SetActive(true);
            unlockText.gameObject.SetActive(true);
            buttonDiary.interactable = false;
        } 
        if (SaveManager.instance.activeSave.trueEnding == true)
        {
            buttonDiary.gameObject.SetActive(true);
            unlockText.gameObject.SetActive(false);
            buttonDiary.interactable = true;
        }



        if (SaveManager.instance.hasLoaded && SaveManager.instance.activeSave.currentLevel != "Page1")
        {
            buttonContinue.gameObject.SetActive(true);
            buttonStart.gameObject.SetActive(false);
        }
        else
        {
            buttonContinue.gameObject.SetActive(false);
            buttonStart.gameObject.SetActive(true);
        }
    }

    public void RestartStartButton()
    {
        buttonStart.gameObject.SetActive(true);
        buttonContinue.gameObject.SetActive(false);
        buttonDiary.gameObject.SetActive(false);
        unlockText.gameObject.SetActive(false);
        ActivePictureManager.instance.pictures[0].SetActive(false);
        ActivePictureManager.instance.pictures[1].SetActive(false);
        ActivePictureManager.instance.pictures[2].SetActive(false);
        ActivePictureManager.instance.pictures[3].SetActive(false);
        ActivePictureManager.instance.pictures[4].SetActive(false);
    }
}
