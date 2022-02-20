using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogCanvasManager_Page9C : MonoBehaviour
{

    [SerializeField]
    GameObject dialogCanvas;


    public void StartDialog()
    {
        dialogCanvas.SetActive(true);
    }

    //No StopDialog needed because the Choice button opens the next page without PageTurner animation
}
