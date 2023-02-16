using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page3C : MonoBehaviour
{
    public GameObject realPrincess;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen 
    public Transform[] princessPositions;
    public GameObject skeleton;
    public Camera illustrationCamera;

    private int currentPrincessPosition;
    private float princessSpeed;
    private Animator anim;
    private GameObject ring;
    private Collider2D ringCollider;


    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        princessSpeed = realPrincess.GetComponent<MoveToClick>().speed * 5;
        ring = GameObject.Find("FingerSound");
        ringCollider = ring.GetComponent<Collider2D>();

        if (SaveManager.instance.activeSave.onTree == true)
        {
            currentPrincessPosition = 0;
            StartCoroutine(Shake());
        }

        else
        {
            currentPrincessPosition = 1;
            princessStartPosition = princessPositions[1];
            skeleton.GetComponent<Animator>().SetBool("SkeletonHidden", true);
        }

        transform.position = princessStartPosition.position;
    }
    private void Update()
    {


        if (currentPrincessPosition == 0)
        {
            anim.SetBool("Jump", true);
        }

        else if (currentPrincessPosition == 1)
        {
            anim.SetBool("Jump", false);
            anim.SetBool("TakeRing", true);
            skeleton.GetComponent<Animator>().SetBool("Skeleton_Fingerless", true);
            if (ringCollider != null)
                ringCollider.enabled = true;
            Invoke("RemoveObject", 0.3f);

        }
        else if (currentPrincessPosition == 2)
        {
            anim.SetBool("TakeRing", false);
            anim.SetBool("InspectRing", true);

        }

        if (transform.position == princessPositions[currentPrincessPosition].position)
        {
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
        }
    }

    IEnumerator Shake()
    {
        yield return new WaitForSeconds(0.8f);
        illustrationCamera.GetComponent<StressReceiver>().InduceStress(1f);
    }

    void RemoveObject()
    {
        Destroy(ring);
    }

}
