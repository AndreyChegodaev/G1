using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogCanvasManager : MonoBehaviour
{


    [SerializeField]
    GameObject dialogCanvas;




    public void StartDialog()
    {
        dialogCanvas.SetActive(true);
    }

    public void StopDialog()
    {
        dialogCanvas.SetActive(false);
        if (SaveManager.instance.activeSave.currentLevel == "Page6v2" || SaveManager.instance.activeSave.currentLevel == "Page6.5A" || SaveManager.instance.activeSave.currentLevel == "Page11A")
        {
            PageTurnerForDialog.instance.TaskOnClick();
        }
        else BookCloser.instance.TaskOnClick();
        //PageTurnerForDialog.instance.TaskOnClick();
    }

}
