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
        // NOTE: Mind that the text in the quotation marks is case sensitive. E.g., "page6v2" or "page11a" won't work.
        if (SaveManager.instance.activeSave.currentLevel == "Page6v2" || SaveManager.instance.activeSave.currentLevel == "Page65A" || SaveManager.instance.activeSave.currentLevel == "Page11A")
        {
            PageTurnerForDialog.instance.TaskOnClick();
        }
        else BookCloser.instance.TaskOnClick();
        //PageTurnerForDialog.instance.TaskOnClick();
    }

}
