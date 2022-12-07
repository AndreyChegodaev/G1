using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager_Page5 : MonoBehaviour
{
    public static CameraManager_Page5 instance;

    public Camera illustrationCamera;
    public GameObject[] cameraPositions;
    public float camFollowSpeed;
    public GameObject lens;
    public GameObject sepiaLayer;
    [Header("Usuallly, cameraPositions length - 1")]
    public int lensOnPosition;

    public int currentCamPosition;

    private float t = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (SaveManager.instance.activeSave.dejaVu == 0)
        {
            currentCamPosition = 0;
        }
        else
        {
            illustrationCamera.transform.position = cameraPositions[0].transform.position;
            currentCamPosition = 1;
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (currentCamPosition <= cameraPositions.Length - 1)
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

        if (currentCamPosition <= cameraPositions.Length - 1)
        {
            illustrationCamera.transform.position = cameraPositions[currentCamPosition].transform.position;
            currentCamPosition++;
            //Debug.Log("current cam position " + currentCamPosition + " of " + cameraPositions.Length);
        }


    }
}
