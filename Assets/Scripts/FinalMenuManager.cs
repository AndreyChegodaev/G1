using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalMenuManager : MonoBehaviour
{
    public static FinalMenuManager instance;

    [SerializeField]
    Button buttonStart;
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
            buttonDiary.interactable = false;
        }

    }

    public void RestartStartButton()
    {
        buttonStart.gameObject.SetActive(true);
        buttonDiary.gameObject.SetActive(false);
        unlockText.gameObject.SetActive(false);
    }
}
