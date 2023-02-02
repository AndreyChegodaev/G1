using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class CameraManager_PF3O : MonoBehaviour
{
    public static CameraManager_PF3O instance;

    public Camera illustrationCamera;
    public List<Transform> cameraPositions = new List<Transform>();
    public float camFollowSpeed;
    public GameObject lens;
    public GameObject sepiaLayer;
    [Header("Usuallly, cameraPositions length - 1")]
    public int lensOnPosition;
    public int currentCamPosition;
    private float t = 0;
    private bool waited = false;

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

        currentCamPosition = 0;

        StartCoroutine(WaitToMove());
    }

    // Update is called once per frame
    void Update()
    {

        if (currentCamPosition <= cameraPositions.Count - 1 && waited == true)
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

    IEnumerator WaitToMove()
    {
        yield return new WaitForSeconds(8);
        waited = true;
    }
}
