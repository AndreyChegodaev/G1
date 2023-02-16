using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page35 : MonoBehaviour
{
    public GameObject realPrincess;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen 
    public Transform[] princessPositions;

    private int currentPrincessPosition;
    private float princessSpeed;
    private bool collisionWithFork;
    //private bool princessIsCreated = false;
    private Animator anim;
    private SoundDesignManager sound;


    void Start()
    {
        collisionWithFork = false;
        anim = gameObject.GetComponent<Animator>();
        princessSpeed = realPrincess.GetComponent<MoveToClick>().speed / 3;
        currentPrincessPosition = 0;
        transform.position = princessStartPosition.position;
        sound = GameObject.Find("ForkSound").GetComponent<SoundDesignManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (currentPrincessPosition == 0)
        {
            anim.SetBool("CrawlTree", true);
            anim.SetFloat("Horizontal", 1);
            anim.SetFloat("Vertical", -0.5f);
        }

        if (currentPrincessPosition == 1)
        {
            anim.SetBool("Shrug", true);
            sound.audioSource.Stop();
        }


        if (collisionWithFork == true)
        {
            anim.SetBool("ForkPicked", true);
            anim.SetFloat("Speed", 0);
        }
    }

    void FixedUpdate()
    {
        if (currentPrincessPosition <= princessPositions.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, princessPositions[currentPrincessPosition].position, princessSpeed * Time.deltaTime);
        }


        if (collisionWithFork == true)
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



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fork")
        {
            //Debug.Log("Mushroom");
            collisionWithFork = true;
        }
    }

    IEnumerator WaitForFork()
    {
        yield return new WaitForSeconds(4.25f);
        anim.SetBool("ForkPicked", false);
        anim.SetFloat("Speed", 0);
        anim.SetFloat("Horizontal", 1);
        anim.SetFloat("Vertical", -0.5f);
        collisionWithFork = false;
    }
}
