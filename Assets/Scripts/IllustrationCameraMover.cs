using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllustrationCameraMover : MonoBehaviour
{
    public Transform targetPosition;
    public Camera illustrationCamera;
    public float zoomSpeed;
    public float followSpeed;
    public float cameraSize;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //zoom
        illustrationCamera.orthographicSize = Mathf.MoveTowards(illustrationCamera.orthographicSize, cameraSize, zoomSpeed * Time.deltaTime);
        //follow
        illustrationCamera.transform.position = Vector3.MoveTowards(illustrationCamera.transform.position, targetPosition.position, followSpeed * Time.deltaTime);
    }
}
