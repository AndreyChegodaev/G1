using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnifier : MonoBehaviour
{
    public Camera illustrationCamera;

    private RaycastHit2D hit;
    private SpriteRenderer sprite;


    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        sprite.enabled = false;
    }

    private void Update()
    {
        hit = Physics2D.Raycast(illustrationCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);


        if (hit.collider && CameraManager.instance.currentCamPosition == CameraManager.instance.lensOnPosition)
        {
            if (hit.collider.name == "Magnifier" || hit.collider.name == "Ring" || hit.collider.name == "Finger" )
            {
                sprite.enabled = true;
            }
            else if (hit.collider.name == "MagnifierOut") sprite.enabled = false;
        }
    }
}
