using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllustrationCamResolutionFix : MonoBehaviour
{
    private Camera mainCam;
    private Camera illustrationCam;
    // Start is called before the first frame update
    void Start()
    {
        illustrationCam = GameObject.Find("Illustration Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mainCam = Camera.main;
        if (mainCam.aspect <= 1.6f)
        {
            illustrationCam.rect = new Rect(0.56f, 0.09f, 0.3f, 0.78f);
        }
        else illustrationCam.rect = new Rect(0.56f, 0.09f, 0.28f, 0.78f);
    }
}
