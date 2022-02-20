using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogCanvasManager_Page65A : MonoBehaviour
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
            PageTurnerForDialog_Page65A.instance.TaskOnClick();
    }

}
