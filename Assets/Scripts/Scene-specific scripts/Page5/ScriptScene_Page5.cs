using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page5 : MonoBehaviour
{
    public GameObject realPrincess;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen 
    public Transform[] princessPositions;

    public Camera illustraionCamera;

    private int currentPrincessPosition;
    private float princessSpeed;
    private bool shrug;
    private bool princessIsCreated = false;
    private Animator anim;


    void Start()
    {
        if (SaveManager.instance.activeSave.dejaVu == 0)
        {
            currentPrincessPosition = 0;
        } else
        {
            currentPrincessPosition = 1;
            princessStartPosition = princessPositions[0];
        }



        shrug = false;
        anim = gameObject.GetComponent<Animator>();
        princessSpeed = realPrincess.GetComponent<MoveToClick>().speed;
        transform.position = princessStartPosition.position;

        gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
    }
    private void Update()
    {


        if (currentPrincessPosition == 0)
        {

            anim.SetFloat("Speed", 70);
            anim.SetFloat("Horizontal", 1);
            anim.SetFloat("Vertical", -0.5f);

        }

        else if (currentPrincessPosition == 1)
        {
            //gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
            anim.SetFloat("Speed", 70);
            anim.SetFloat("Horizontal", 1);
            anim.SetFloat("Vertical", -0.5f);
        }


        if (transform.position == princessPositions[currentPrincessPosition].position)
        {
            anim.SetFloat("Speed", 0);
        }

        if (transform.position == princessPositions[currentPrincessPosition].position && currentPrincessPosition == CameraManager_Page5.instance.lensOnPosition)
        {
            SwapPrincesses();
        }


        if (shrug == true)
        {
            anim.SetBool("Shrug", true);
            anim.SetFloat("Speed", 0);
            StartCoroutine(Shrug());
            shrug = !shrug;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentPrincessPosition <= princessPositions.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, princessPositions[currentPrincessPosition].position, princessSpeed * Time.deltaTime);
        }


        if (shrug == true)
        {
            princessSpeed = 0;

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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shrug")
        {
           // Debug.Log("Shrug");
            shrug = true;
        }
    }


    IEnumerator Shrug()
    {
        yield return new WaitForSeconds(2);
        anim.SetBool("Shrug", false);
    }
}
