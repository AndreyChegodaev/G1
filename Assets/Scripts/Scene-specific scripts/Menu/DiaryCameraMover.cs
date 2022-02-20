using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiaryCameraMover : MonoBehaviour
{
    public static DiaryCameraMover instance;
    
    public Camera mainCamera;
    public Transform cameraFinalPosition;
    public float followSpeed = 3f;
    public float timeBeforeSceneLoad = 8;
    public string sceneName;
    private float rotationSpeed;
    private bool flag1 = false; // on when the button is pressed
    private float elapsedTime;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        rotationSpeed = followSpeed / 4;
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
            LoadScene();
        }
    }
    
    public void TaskOnClick()
    {
        flag1 = true;
    }

    void LoadScene()
    {
        //SaveManager.instance.Save(); do I need to save the game when it goes to Diary?
        SceneManager.LoadScene(sceneName);
        //SaveManager.instance.activeSave.currentLevel = sceneName;
    }
}
