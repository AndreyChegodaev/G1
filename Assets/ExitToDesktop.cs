using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitToDesktop : MonoBehaviour
{
    public Image fade;
    private Camera cam;
    private Transform camPosition;
    private Vector3 startCamPosition;
    public GameObject DLCPopup;

    private void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        camPosition = cam.transform;
        startCamPosition = new Vector3(camPosition.position.x, camPosition.position.y, camPosition.position.z);
        fade.gameObject.SetActive(false);
    }
    public void TaskOnClick()
    {
        fade.gameObject.SetActive(true);
        fade.CrossFadeAlpha(0f, 0f, true);
        fade.CrossFadeAlpha(1f, 0.5f, false);
        Invoke("Exit", 0.5f);
    }

    private void Update()
    {
        if (camPosition.position != startCamPosition || DLCPopup.activeSelf == true)
        {
            gameObject.SetActive(false);
        }
    }

    void Exit()
    {
        Application.Quit();
    }
}
