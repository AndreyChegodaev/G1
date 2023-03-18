using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class ScriptScene_PF2B : MonoBehaviour
{

    public GameObject realPrincess;
    GameObject witch;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen 
    public Transform[] princessPositions;

    private int currentPrincessPosition;
    private float princessSpeed;
    private Animator anim;

    private bool readyToFire = true;

    // Start is called before the first frame update
    void Start()
    {
        witch = GameObject.FindGameObjectWithTag("Witch");
        anim = gameObject.GetComponent<Animator>();
        princessSpeed = realPrincess.GetComponent<MoveToClick>().speed;
        currentPrincessPosition = 0;
        transform.position = princessStartPosition.position;
    }
    private void Update()
    {


        if (currentPrincessPosition == 0)
        {
            anim.SetBool("PrepareToCharge", true);
        }

        else if (currentPrincessPosition == 1)
        {
            anim.SetBool("Charge", true);

            if (readyToFire == true)
            {
                witch.GetComponent<Animator>().SetBool("IsFiring", true);
                readyToFire = !readyToFire;
            }

            StartCoroutine(BackToIdle());
        }



        if (transform.position == princessPositions[currentPrincessPosition].position)
        {
            anim.SetFloat("Speed", 0);
            princessSpeed = 0;
        }

        if (witch.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("witch_fire"))
        {
            anim.speed = 1f;
            princessSpeed = 2f;

        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("princess_ashes"))
        {
            anim.SetFloat("Speed", 0);
            princessSpeed = 0;
            //var achievement = new Steamworks.Data.Achievement("ACHIEVEMENT_WarmWelcome").Trigger();

            if (SteamManager.Initialized)
            {
                SteamUserStats.SetAchievement("ACHIEVEMENT_WarmWelcome");
                SteamUserStats.StoreStats();
            }
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

    IEnumerator BackToIdle()
    {
        yield return new WaitForSeconds(1.5f);
        witch.GetComponent<Animator>().SetBool("IsFiring", false);
    }
}
