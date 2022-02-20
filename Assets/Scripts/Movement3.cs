using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement3 : MonoBehaviour
{  
    public Quaternion rotationDirection;
    public float rotationTime;
    public float coroutineTimer;

    private bool flag = false;
    private bool rotation = false;


    void Start()
    {
        rotation = true;
        StartCoroutine(Timer());
    }

    void Update()
    {
        float smooth = Time.deltaTime * -rotationTime;

        if (rotation == true)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotationDirection, smooth);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(coroutineTimer);
        flag = true;
    }

    private void LateUpdate()
    {
        float smooth = Time.deltaTime * rotationTime;

        if (flag == true)
        {
            rotation = false;
        }

    }
}
