using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_Fader : MonoBehaviour
{
    public static Intro_Fader instance;

    public GameObject fader;
    public Camera targetCamera;
    public bool fadeOutReady = false;
    public bool fadeInReady = false;
    public float transitionTime = 3f;

    private Vector3 finishPosition_out;
    private Vector3 finishPosition_in;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        finishPosition_out = targetCamera.transform.position;
        finishPosition_in = new Vector3(fader.transform.position.x, fader.transform.position.y, fader.transform.position.z - 10);
    }

    void FixedUpdate()
    {
        if (fadeOutReady == true)
        {
            FadeOut();
        }

        if (fadeInReady == true)
        {
            FadeIn();
        }

    }

   public void FadeOut()
    {
        fader.transform.position = Vector3.Lerp(fader.transform.position, finishPosition_out, Time.deltaTime * transitionTime);
    }

    public void FadeIn()
    {
        fader.transform.position = Vector3.Lerp(fader.transform.position, finishPosition_in, Time.deltaTime * transitionTime);
    }

}


