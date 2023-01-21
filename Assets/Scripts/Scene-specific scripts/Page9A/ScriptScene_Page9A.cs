using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page9A : MonoBehaviour
{
    public GameObject realPrincess;

    public Transform princessStartPosition; // have to do it because of a bug with Full sreen 
    public Transform[] princessPositions;

    private int currentPrincessPosition;
    private bool princessIsCreated = false;

    void Start()
    {
        currentPrincessPosition = 1;
        transform.position = princessStartPosition.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position == princessPositions[currentPrincessPosition].position && currentPrincessPosition == CameraManager.instance.lensOnPosition)
        {
            SwapPrincesses();
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
