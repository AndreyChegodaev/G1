using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax_Page5 : MonoBehaviour
{
    public GameObject[] planes;
    public Camera illustrationCamera;
    public Transform cameraNextPosition;
    public float speed = 0.2f;
    public float parallaxCoefficient = 1f;
    Vector3 direction;

    
    void Start()
    {
        direction = new Vector3(cameraNextPosition.position.x, cameraNextPosition.position.y);

    }
/*
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(direction, new Vector3(5, 5));
    }
*/
    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (GameObject plane in planes)
        {
            plane.transform.position = Vector3.MoveTowards(plane.transform.position, direction, Time.deltaTime * (1/(float)plane.GetComponent<SpriteRenderer>().sortingOrder * parallaxCoefficient) * speed);
        }
    }
}
