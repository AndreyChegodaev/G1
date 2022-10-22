using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnifier : MonoBehaviour
{
    public Camera illustrationCamera;

    private RaycastHit2D hit;
    private SpriteRenderer sprite;
    public bool magnifierReady;


    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        sprite.enabled = false;
        magnifierReady = false;
    }

    private void Update()
    {
        if (CameraManager.instance.currentCamPosition >= CameraManager.instance.lensOnPosition)
        {
            magnifierReady = true;
        }

        hit = Physics2D.Raycast(illustrationCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);


        if (hit.collider && magnifierReady == true)
        {
            if (hit.collider.name == "Magnifier" || hit.collider.name == "Ring" || hit.collider.name == "Finger" || hit.collider.name == "Arm")
            {
                sprite.enabled = true;
            }
            else if (hit.collider.name == "MagnifierOut") sprite.enabled = false;
        }
    }
}
