using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page65A : MonoBehaviour
{
    public GameObject realPrincess;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen 
    public Transform[] princessPositions;

    private int currentPrincessPosition;
    private float princessSpeed;
    private bool giveHand = false;
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


        if (transform.position == princessPositions[currentPrincessPosition].position)
        {
            anim.SetFloat("Speed", 0);
        }

        if (giveHand == true)
        {
            princessSpeed = 0;
            anim.SetBool("Knock", true);
            anim.SetFloat("Speed", 0);
            giveHand = !giveHand;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Knock")
        {
            giveHand = true;
        }
    }
}
