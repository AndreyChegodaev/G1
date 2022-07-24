using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurtainManager : MonoBehaviour
{
    public Image curtainRight; 
    public int timer;


    // Start is called before the first frame update
    void Start()
    {
        curtainRight.canvasRenderer.SetAlpha(1f);
        StartCoroutine(MakeVisible());

    }

    IEnumerator MakeVisible()
    {
        yield return new WaitForSeconds(1f);
        curtainRight.CrossFadeAlpha(0f, timer, false);
    }

}
