using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPageCameraMover : MonoBehaviour
{
    public static SelectPageCameraMover instance;
   
    public Camera mainCamera;
    public Transform cameraFinalPosition;
    public float followSpeed = 3f;
    public float timeBeforeSceneLoad = 8;
    public GameObject selectPageUI;
    private float rotationSpeed;
    private bool flag1 = false; // on when the button is pressed
    private bool hasShaken;
    private float elapsedTime;
    private GameObject book;

    public void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        rotationSpeed = followSpeed / 4;
        book = GameObject.FindGameObjectWithTag("Book");
    }

    private void Update()
    {
       if (book.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("book_close"))
        {
            if (hasShaken == false)
            {
                StartCoroutine(Shake());
                hasShaken = !hasShaken;
            }

        }
    }

    private void LateUpdate()
    {
        if (flag1 == true)
        {
            elapsedTime += Time.deltaTime;
            Vector3 currentAngle = new Vector3(
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, cameraFinalPosition.transform.rotation.eulerAngles.x, rotationSpeed * Time.deltaTime),
            Mathf.LerpAngle(transform.rotation.eulerAngles.y, cameraFinalPosition.transform.rotation.eulerAngles.y, rotationSpeed * Time.deltaTime),
            Mathf.LerpAngle(transform.rotation.eulerAngles.z, cameraFinalPosition.transform.rotation.eulerAngles.z, rotationSpeed * Time.deltaTime));

            transform.eulerAngles = currentAngle;

            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, cameraFinalPosition.position + Vector3.forward * -2, followSpeed * Time.deltaTime);


            if (elapsedTime >= timeBeforeSceneLoad)
                selectPageUI.SetActive(true);
        }
    }
    
    public void TaskOnClick()
    {
        flag1 = true;
    }

    IEnumerator Shake()
    {
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<StressReceiver>().InduceStress(1.2f);
    }
}
