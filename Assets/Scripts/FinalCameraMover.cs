using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalCameraMover : MonoBehaviour
{

    public Camera mainCamera;
    GameObject witchVision;

  
    //public float zoomSpeed;
    //public List<float> cameraSizes = new List<float>();

    public float followSpeed = 3;
    float rotationSpeed;
    public List<Transform> cameraPositions = new List<Transform>();
    public Button forward;
    int i = -1;
    bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = followSpeed / 4;

        forward.gameObject.SetActive(false);
        forward.onClick.AddListener(TaskOnClick);

        witchVision = GameObject.Find("WitchVision");
        if (witchVision != null)
        witchVision.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {                
        if (flag == true) { 
        Vector3 currentAngle = new Vector3(
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, cameraPositions[i].transform.rotation.eulerAngles.x, rotationSpeed * Time.deltaTime),
            Mathf.LerpAngle(transform.rotation.eulerAngles.y, cameraPositions[i].transform.rotation.eulerAngles.y, rotationSpeed * Time.deltaTime),
            Mathf.LerpAngle(transform.rotation.eulerAngles.z, cameraPositions[i].transform.rotation.eulerAngles.z, rotationSpeed * Time.deltaTime));

        transform.eulerAngles = currentAngle;

        mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, cameraPositions[i].position + Vector3.forward * -2, followSpeed * Time.deltaTime);
        }

    }

    void TaskOnClick()
    {
        i++;
        flag = true;
        
        if (i == 4)
        {
            GameManager.instance.FirstPlaytroughDone();
        }

        if (i == 5)
        {
            if (witchVision != null)
            witchVision.SetActive(true);
        }
    }

}
