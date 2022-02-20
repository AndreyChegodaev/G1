using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCameraMover : MonoBehaviour
{
    public Camera mainCamera;
    public Transform CameraFinalPosition;
    public float movementSpeed = 1.5f;
    public float timeBeforeSceneLoad = 8;
    public string sceneName;
    private bool flag1 = false; // on when the button is pressed
    private float elapsedTime;




    private void Update()
    {
        if (flag1 == true)
        {
            elapsedTime += Time.deltaTime;
            
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, CameraFinalPosition.position + Vector3.forward * -2, movementSpeed * Time.deltaTime);

            Vector3 currentAngle = new Vector3(
                Mathf.LerpAngle(mainCamera.transform.rotation.eulerAngles.x, CameraFinalPosition.transform.rotation.eulerAngles.x, movementSpeed * Time.deltaTime),
                Mathf.LerpAngle(mainCamera.transform.rotation.eulerAngles.y, CameraFinalPosition.transform.rotation.eulerAngles.y, movementSpeed * Time.deltaTime),
                Mathf.LerpAngle(mainCamera.transform.rotation.eulerAngles.z, CameraFinalPosition.transform.rotation.eulerAngles.z, movementSpeed * Time.deltaTime));

            transform.eulerAngles = currentAngle;

            

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
        SaveManager.instance.Save();
        SceneManager.LoadScene(sceneName);
        SaveManager.instance.activeSave.currentLevel = sceneName;
    }
}
