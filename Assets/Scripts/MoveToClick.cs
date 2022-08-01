using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToClick : MonoBehaviour
{
    public float speed = 5f;
    public Camera illustrationCamera;
    private Vector3 target;
    private GameObject[] boarders;
    
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = illustrationCamera.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;


            // learn the explanation here: https://forum.unity.com/threads/blend-tree-mouse-movement.735263/ 
            
            Vector3 deltaPosition = target - transform.position;

            Vector3 targetDirection = deltaPosition.normalized;

            gameObject.GetComponent<Animator>().SetFloat("Horizontal", targetDirection.x);
            gameObject.GetComponent<Animator>().SetFloat("Vertical", targetDirection.y);
            gameObject.GetComponent<Animator>().SetFloat("Speed", deltaPosition.sqrMagnitude);
        } 

        if (transform.position == target)
        {
            gameObject.GetComponent<Animator>().SetFloat("Speed", 0);
        }

    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (target == transform.position)
        {
            gameObject.GetComponent<Animator>().SetFloat("Speed", 0);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "IllustrationFrame")
        {
            boarders = GameObject.FindGameObjectsWithTag("IllustrationFrame");
            foreach (GameObject boarder in boarders)
            {
                boarder.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "IllustrationFrame")
        {
            gameObject.GetComponent<Animator>().SetFloat("Speed", 0);
            target = transform.position;
            Debug.Log("Collision: Princess/Frame");
        }

    }
}
