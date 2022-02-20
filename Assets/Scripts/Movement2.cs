using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement2 : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed;
    public Button moveToNextPosition;
    public Quaternion rotationDirection;
    public float rotationTime;
    public float coroutineTimer;
    
    //private bool flag = false;
    private bool flag2 = false;
    private bool rotation = false;
   
     
    void Start()
    {
        //moveToNextPosition.onClick.AddListener(TaskOnClick);
        rotation = true;
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    public void TaskOnClick()
    {
        //flag = true;

    }

    void Update()
    {
        float smooth = Time.deltaTime * rotationTime;
        
        if (//flag == true && 
            rotation == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[1].transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotationDirection, smooth);
        }
    }

    IEnumerator Timer()
    { 
        yield return new WaitForSeconds(coroutineTimer);
        flag2 = true;
    }

    private void LateUpdate()
    {
        float smooth = Time.deltaTime * rotationTime;

        if (//flag == true && 
            flag2 == true)
        {
            rotation = false;
            transform.position = Vector3.MoveTowards(transform.position, waypoints[0].transform.position, speed * Time.deltaTime);
        }

    }
}
