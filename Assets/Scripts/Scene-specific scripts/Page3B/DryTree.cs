using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DryTree : MonoBehaviour
{
    public float movementSpeed = 1;
    public float movementDistance = 0.5f;
    private SpriteRenderer sprite;
    private Vector2 finalPosition;

    // Start is called before the first frame update
    void Start()
    {
        finalPosition = new Vector2 (transform.position.x, transform.position.y - movementDistance);
        sprite = gameObject.GetComponent<SpriteRenderer>();
        
        if (SaveManager.instance.activeSave.onTree == false) sprite.enabled = false;
        else sprite.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraManager.instance.currentCamPosition == CameraManager.instance.lensOnPosition)
        {
            sprite.enabled = true;
            gameObject.transform.position = Vector2.MoveTowards(transform.position, finalPosition, Time.deltaTime * movementSpeed);
        }
    }
}
