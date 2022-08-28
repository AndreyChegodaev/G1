using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_lense : MonoBehaviour
{
    public static Intro_lense instance;

    public GameObject lense;
    public Camera targetCamera;
    public bool lenseReady = false;
    public float transitionTime = 3f;

    private Vector3 startPosition;
    private Vector3 finishPosition;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        startPosition = lense.transform.position;
        finishPosition = new Vector3 (targetCamera.transform.position.x, targetCamera.transform.position.y, targetCamera.transform.position.z - 2);

    }

    void FixedUpdate()
    {
        if (lenseReady == true)
        {
            LenseMove();
        }

        if (lense.transform.position == finishPosition)
        {
            lense.transform.position = startPosition;
            lenseReady = false;
        }

    }

    public void LenseMove()
    {
        lense.transform.position = Vector3.MoveTowards(lense.transform.position, finishPosition, Time.deltaTime * transitionTime);
    }

}
