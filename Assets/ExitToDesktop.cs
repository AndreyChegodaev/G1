using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitToDesktop : MonoBehaviour
{
    public Image fade;

    private void Start()
    {
        fade.gameObject.SetActive(false);
    }
    public void TaskOnClick()
    {
        fade.gameObject.SetActive(true);
        fade.CrossFadeAlpha(0f, 0f, true);
        fade.CrossFadeAlpha(1f, 0.5f, false);
        Invoke("Exit", 0.5f);
    }

    void Exit()
    {
        Application.Quit();
    }
}
