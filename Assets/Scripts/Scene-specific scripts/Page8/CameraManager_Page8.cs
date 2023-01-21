using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager_Page8 : MonoBehaviour
{
    public static CameraManager_Page8 instance;

    public Camera illustrationCamera;
    public List<Transform> cameraPositions = new List<Transform>();
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
        if (SaveManager.instance.activeSave.heardVoice == true)
        {
            currentCamPosition = 0;
        }
        else
        {
            illustrationCamera.transform.position = cameraPositions[0].transform.position;
            currentCamPosition = 1;

        }

        if (SaveManager.instance.activeSave.hasFinger == true)
        {
            cameraPositions[1].position = cameraPositions[2].position;
        }
        else
        {
            cameraPositions[2].position = cameraPositions[1].position;
            cameraPositions[3].position = cameraPositions[1].position;
        }

    }

    // Update is called once per frame
    void Update()
    {

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
