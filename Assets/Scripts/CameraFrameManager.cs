using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFrameManager : MonoBehaviour
{
    public Camera illustrationCamera;


     void Start()
    {
        gameObject.transform.position = illustrationCamera.transform.position + Vector3.forward * 5;

    }
}
