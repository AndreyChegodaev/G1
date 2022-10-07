using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page4 : MonoBehaviour
{
    public GameObject realPrincess;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen 
    public Transform[] princessPositions;

    private int currentPrincessPosition;
    private float princessSpeed;
    private bool princessIsCreated = false;
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        princessSpeed = realPrincess.GetComponent<MoveToClick>().speed / 3;
        currentPrincessPosition = 0;
        transform.position = princessStartPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPrincessPosition == 0)
        {
            anim.SetBool("InspectRing", true);
        }

        if (currentPrincessPosition == 1)
        {
            anim.SetBool("Shrug", true);
        }

        if (transform.position == princessPositions[currentPrincessPosition].position && currentPrincessPosition == CameraManager.instance.lensOnPosition)
        {
            SwapPrincesses();
        }
    }

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
}
