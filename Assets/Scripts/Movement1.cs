using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement1 : MonoBehaviour
{
    public Transform waypoint1;
    public float speed;

    private void Start()
    {

    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoint1.transform.position, speed * Time.deltaTime);
       
    }

}
