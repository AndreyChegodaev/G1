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
            PageTurnerForDialog.instance.TaskOnClick();
    }

}
