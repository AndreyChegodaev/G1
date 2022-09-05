using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page1 : MonoBehaviour
{
    public GameObject scriptPrincess;
    public GameObject realPrincess;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen mode
    public Transform[] princessPositions;
    
    private int currentPrincessPosition;
    private float princessSpeed;
    private bool princessIsCreated = false;
   
    void Start()
    {
        princessSpeed = MoveToClick.instance.speed;
        currentPrincessPosition = 0;
        scriptPrincess.transform.position = princessStartPosition.position;
    }
    private void Update()
    {
 
        currentPrincessPosition = CameraManager.instance.currentCamPosition;

        if (currentPrincessPosition == 0)
        {
            scriptPrincess.GetComponent<Animator>().SetFloat("Speed", 70);
            scriptPrincess.GetComponent<Animator>().SetFloat("Horizontal", 1);
            scriptPrincess.GetComponent<Animator>().SetFloat("Vertical", -0.5f);

        }

        else if (currentPrincessPosition == 1)
        {
            scriptPrincess.GetComponent<Animator>().SetFloat("Speed", 70);
            scriptPrincess.GetComponent<Animator>().SetFloat("Horizontal", 0.5f);
            scriptPrincess.GetComponent<Animator>().SetFloat("Vertical", 0.5f);
        } 
        else if (currentPrincessPosition == 2)
        {
            scriptPrincess.GetComponent<Animator>().SetFloat("Speed", 70);
            scriptPrincess.GetComponent<Animator>().SetFloat("Horizontal", -0.5f);
            scriptPrincess.GetComponent<Animator>().SetFloat("Vertical", -0.5f);
        }

        if (scriptPrincess.transform.position == princessPositions[currentPrincessPosition].position)
        {
            scriptPrincess.GetComponent<Animator>().SetFloat("Speed", 0);
        }

        if (scriptPrincess.transform.position == princessPositions[currentPrincessPosition].position && currentPrincessPosition == CameraManager.instance.lensOnPosition)
        {
            SwapPrincesses();
        }

        if (Mushroom.instance.collisionWithMushroom == true)
        {

            scriptPrincess.GetComponent<Animator>().SetFloat("Speed", 0);
            scriptPrincess.GetComponent<Animator>().SetFloat("Horizontal", 1);
            scriptPrincess.GetComponent<Animator>().SetFloat("Vertical", -0.5f);

            StartCoroutine(WaitForMushroom());

        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scriptPrincess.transform.position = Vector3.MoveTowards(scriptPrincess.transform.position, princessPositions[currentPrincessPosition].position, princessSpeed * Time.deltaTime);

        if (Mushroom.instance.collisionWithMushroom == true)
        {
            princessSpeed = 0;
        }
    }

    void SwapPrincesses()
    {
        scriptPrincess.SetActive(false);
        if (princessIsCreated == false)
        {
            Instantiate(realPrincess, new Vector3(scriptPrincess.transform.position.x, scriptPrincess.transform.position.y, scriptPrincess.transform.position.z), Quaternion.identity);
            princessIsCreated = true;
        }

    }


    IEnumerator WaitForMushroom()
    {
        yield return new WaitForSeconds(2);
        scriptPrincess.GetComponent<Animator>().SetFloat("Speed", 70);
        scriptPrincess.GetComponent<Animator>().SetFloat("Horizontal", 1);
        scriptPrincess.GetComponent<Animator>().SetFloat("Vertical", -0.5f);
        Mushroom.instance.collisionWithMushroom = false;
        princessSpeed = MoveToClick.instance.speed;
    }
}
