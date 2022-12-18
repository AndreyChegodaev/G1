using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_PF1B : MonoBehaviour
{
    public GameObject realPrincess;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen 
    public Transform[] princessPositions;

    private int currentPrincessPosition;
    private float princessSpeed;
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        princessSpeed = realPrincess.GetComponent<MoveToClick>().speed;
        currentPrincessPosition = 0;
        transform.position = princessStartPosition.position;
    }
    private void Update()
    {


        if (currentPrincessPosition == 0)
        {

            anim.SetFloat("Speed", 70);
            anim.SetFloat("Horizontal", 0.5f);
            anim.SetFloat("Vertical", 0.5f);

        }

        if (currentPrincessPosition == 1)
        {
            anim.SetBool("Knock", true);
        }

        if (currentPrincessPosition == 2)
        {
            anim.SetBool("PickUpKey", true);
        }

        if (currentPrincessPosition == 3)
        {
            anim.SetBool("SitFinal", true);
        }



        if (transform.position == princessPositions[currentPrincessPosition].position)
        {
            //princessSpeed = 0;
            anim.SetFloat("Speed", 0);
        }


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentPrincessPosition <= princessPositions.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, princessPositions[currentPrincessPosition].position, princessSpeed * Time.deltaTime);

        }
    }

    public void TaskOnClick()
    {
        if (currentPrincessPosition <= princessPositions.Length - 1)
        {
            transform.position = princessPositions[currentPrincessPosition].transform.position;
            currentPrincessPosition++;
            //Debug.Log("current position " + currentPrincessPosition);
        }
    }
}
