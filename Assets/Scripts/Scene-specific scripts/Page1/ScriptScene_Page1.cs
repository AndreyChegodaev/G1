using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page1 : MonoBehaviour
{
    public GameObject realPrincess;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen 
    public Transform[] princessPositions;
    
    private int currentPrincessPosition;
    private float princessSpeed;
    private bool collisionWithMushroom;
    private bool shrug;
    private bool princessIsCreated = false;
    private Animator anim;
   
    void Start()
    {
        collisionWithMushroom = false;
        shrug = false;
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
            anim.SetFloat("Horizontal", 1);
            anim.SetFloat("Vertical", -0.5f);

        }

        else if (currentPrincessPosition == 1)
        {
            anim.SetFloat("Speed", 70);
            anim.SetFloat("Horizontal", 1);
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
            SwapPrincesses();
        }

        if (collisionWithMushroom == true)
        {
            anim.SetBool("MushroomPicked", true);
            anim.SetFloat("Speed", 0);
            //scriptPrincess.GetComponent<Animator>().SetFloat("Horizontal", 1);
            //scriptPrincess.GetComponent<Animator>().SetFloat("Vertical", -0.5f);

            StartCoroutine(WaitForMushroom());

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

        if (collisionWithMushroom == true)
        {
            princessSpeed = 0;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mushroom")
        {
            //Debug.Log("Mushroom");
            collisionWithMushroom = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shrug")
        {
            Debug.Log("Shrug");
            shrug = true;
        }
    }


    IEnumerator WaitForMushroom()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("MushroomPicked", false);
        anim.SetFloat("Speed", 70);
        anim.SetFloat("Horizontal", 1);
        anim.SetFloat("Vertical", -0.5f);
        collisionWithMushroom = false;
        princessSpeed = realPrincess.GetComponent<MoveToClick>().speed;
    }

    IEnumerator Shrug()
    {
        yield return new WaitForSeconds(2);
        anim.SetBool("Shrug", false);
    }

}
