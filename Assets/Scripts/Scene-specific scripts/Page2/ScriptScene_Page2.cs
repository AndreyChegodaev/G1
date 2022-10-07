using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page2 : MonoBehaviour
{
    public GameObject realPrincess;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen 
    public Transform[] princessPositions;

    private int currentPrincessPosition;
    private float princessSpeed;
    private bool whoosh;
    private bool princessIsCreated = false;
    private Animator anim;

    void Start()
    {
        whoosh = false;
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
            anim.SetFloat("Horizontal", -0.5f);
            anim.SetFloat("Vertical", -0.5f);

        }

        else if (currentPrincessPosition == 1)
        {
            anim.SetFloat("Speed", 70);
            anim.SetFloat("Horizontal", -0.5f);
            anim.SetFloat("Vertical", -0.5f);
        }
        else if (currentPrincessPosition == 2)
        {
            anim.SetFloat("Speed", 70);
            anim.SetFloat("Horizontal", -0.5f);
            anim.SetFloat("Vertical", -0.5f);
        }

        if (transform.position == princessPositions[currentPrincessPosition].position)
        {
            anim.SetFloat("Speed", 0);
        }

        if (transform.position == princessPositions[currentPrincessPosition].position && currentPrincessPosition == CameraManager.instance.lensOnPosition)
        {
            //SwapPrincesses();
        }

        if (whoosh == true)
        {
            anim.SetBool("Whoosh", true);
            anim.SetFloat("Speed", 0);
            StartCoroutine(Whoosh());
            whoosh = !whoosh;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentPrincessPosition <= princessPositions.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, princessPositions[currentPrincessPosition].position, princessSpeed * Time.deltaTime);

        }

        if (whoosh == true)
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
            //Debug.Log("current position " + currentPrincessPosition);
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
        if (collision.gameObject.tag == "Whoosh")
        {
            Debug.Log("Whoosh");
            whoosh = true;
            Leafblower.instance.readyToBlow = true;
        }
    }


    IEnumerator Whoosh()
    {
        yield return new WaitForSeconds(2);

        anim.SetBool("Whoosh", false);
        SwapPrincesses();
    }
}
