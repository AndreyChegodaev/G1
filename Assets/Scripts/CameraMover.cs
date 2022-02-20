using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraMover : MonoBehaviour
{
    public GameObject CameraPositionStart;
    public GameObject CameraPositionFinish;
    public float speed;
    public float adjustedTime;
    public string sceneToLoad;

    float elapsedTime;
    float transitionTime;
 
    public void LateUpdate()
    {
        transitionTime = Time.deltaTime * speed;
        
        transform.position = Vector3.Lerp(transform.position, CameraPositionFinish.transform.position, transitionTime);

        Vector3 currentAngle = new Vector3(
 Mathf.LerpAngle(transform.rotation.eulerAngles.x, CameraPositionFinish.transform.rotation.eulerAngles.x, transitionTime),
 Mathf.LerpAngle(transform.rotation.eulerAngles.y, CameraPositionFinish.transform.rotation.eulerAngles.y, transitionTime),
 Mathf.LerpAngle(transform.rotation.eulerAngles.z, CameraPositionFinish.transform.rotation.eulerAngles.z, transitionTime));

        transform.eulerAngles = currentAngle;

        elapsedTime += Time.deltaTime;

        if (elapsedTime > speed + adjustedTime)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

  

  
}
