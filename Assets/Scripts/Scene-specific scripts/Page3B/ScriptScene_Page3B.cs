using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page3B : MonoBehaviour
{
    public GameObject realPrincess;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen 
    public Transform[] princessPositions;
    public GameObject skeleton;

    private int currentPrincessPosition;
    private float princessSpeed;
    private bool princessIsCreated = false;
    private Animator anim;

    private bool readyToDig;

    void Start()
    {
        readyToDig = true;
        anim = gameObject.GetComponent<Animator>();
        princessSpeed = realPrincess.GetComponent<MoveToClick>().speed;
        currentPrincessPosition = 0;
        transform.position = princessStartPosition.position;
    }
    private void Update()
    {


        if (currentPrincessPosition == 0)
        {
            StartCoroutine(WaitForShowel());
        }

        else if (currentPrincessPosition == 1)
        {

            if (readyToDig == true) anim.SetBool("Dig", true);

            anim.SetBool("TakeShowel", false);
            StartCoroutine(WaitToStopDigging());
            skeleton.GetComponent<Animator>().SetBool("SkeletonDig", true);
        }
        else if (currentPrincessPosition == 2)
        {
            SwapPrincesses();
            skeleton.GetComponent<Animator>().SetBool("SkeletonDig", false);
            skeleton.GetComponent<Animator>().SetBool("SkeletonReady", true);
        }

        if (transform.position == princessPositions[currentPrincessPosition].position)
        {
            anim.SetFloat("Speed", 0);
        }

       /* 
        if (transform.position == princessPositions[currentPrincessPosition].position && currentPrincessPosition == CameraManager.instance.lensOnPosition)
        {
            SwapPrincesses();
        }
       */

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, princessPositions[currentPrincessPosition].position, princessSpeed * Time.deltaTime);
    }

    public void TaskOnClick()
    {
        if (currentPrincessPosition <= princessPositions.Length - 1)
        {
            transform.position = princessPositions[currentPrincessPosition].transform.position;
            currentPrincessPosition++;
        }
    }

    void SwapPrincesses()
    {
        gameObject.SetActive(false);
        if (princessIsCreated == false)
        {
            Instantiate(realPrincess, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            princessIsCreated = true;
        }

    }


    IEnumerator WaitForShowel()
    {
        yield return new WaitForSeconds(3);
        anim.SetBool("TakeShowel", true);
    }

    IEnumerator WaitToStopDigging()
    {

        yield return new WaitForSeconds(6);
        readyToDig = false;
        anim.SetBool("Dig", false);


    }
}
