using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFrameManager : MonoBehaviour
{
    public Camera illustrationCamera;
    float size;
    public float frameSizeAdjustment = 3.2f;

     void Start()
    {
        gameObject.transform.position = illustrationCamera.transform.position + Vector3.forward * 5;

    }

    void Update()
    {
        size = illustrationCamera.orthographicSize;
        gameObject.transform.localScale = Vector3.one * size / frameSizeAdjustment;
    }
}
