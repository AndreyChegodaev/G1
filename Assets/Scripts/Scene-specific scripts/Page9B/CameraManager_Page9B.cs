using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class CameraManager_Page9B : MonoBehaviour
{
    public static CameraManager_Page9B instance;

    public Camera illustrationCamera;
    public List<Transform> cameraPositions = new List<Transform>();
    public float camFollowSpeed;
    public GameObject lens;
    public GameObject sepiaLayer;
    [Header("Usuallly, cameraPositions length - 1")]
    public int lensOnPosition;
    public int currentCamPosition;
    private float t = 0;

    public Volume lensNight;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (SaveManager.instance.activeSave.waitAtTheDoor == 2)
            lensNight.weight = 0.2f;
        else if (SaveManager.instance.activeSave.waitAtTheDoor == 3)
            lensNight.weight = 0.4f;
        else if (SaveManager.instance.activeSave.waitAtTheDoor > 3)
            lensNight.weight = 0.6f;

        if (SaveManager.instance.activeSave.currentLevel == "Page1")
        {
            illustrationCamera.enabled = false;
        }

        currentCamPosition = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (BookManager_Page1.instance.bookShowFirstIllustration == true && BookManager_Page1.instance.bookShowOther == true)
        {
            illustrationCamera.enabled = true;
        }

        if (currentCamPosition <= cameraPositions.Count - 1)
        {
            illustrationCamera.transform.position = Vector3.MoveTowards(illustrationCamera.transform.position, cameraPositions[currentCamPosition].transform.position, camFollowSpeed * Time.deltaTime);
        }

        if (currentCamPosition == lensOnPosition)
        {
            lens.transform.position = Vector3.MoveTowards(lens.transform.position, illustrationCamera.transform.position + Vector3.forward * -4.5f, Time.deltaTime * 4f);
            sepiaLayer.GetComponent<SpriteRenderer>().color = Color.Lerp(sepiaLayer.GetComponent<SpriteRenderer>().color, new Color(1, 1, 1, 0), t);

            if (t < 1)
            {
                t += Time.deltaTime / 5;
            }
        }
    }

    public void TaskOnClick()
    {
        BookManager_Page1.instance.bookShowFirstIllustration = false;

        if (currentCamPosition <= cameraPositions.Count - 1)
        {
            illustrationCamera.transform.position = cameraPositions[currentCamPosition].transform.position;
            currentCamPosition++;
            //Debug.Log("current cam position " + currentCamPosition + " of " + cameraPositions.Length);
        }


    }
}