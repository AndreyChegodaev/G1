using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class Intro_Camera : MonoBehaviour
{

    public float transitionTime = 3f;
    private float t = 0f;
    public Vector3 cameraPositionFinish = new Vector3(5, 0, -10);
    public Color colorStart = new Color(0.8f, 0.8f, 0.8f, 0);
    public Color colorFinish = new Color(0.3f, 0.3f, 0.3f, 0);

    public Volume volume;
    Vignette vignette;


    private void Start()
    {
        volume.profile.TryGet<Vignette>(out vignette);
        gameObject.GetComponent<Camera>().backgroundColor = colorStart;
    }

    // Update is called once per frame
    void Update()
    {
        if (Intro_Jar.instance.jarIsReady == true)
        {
            vignette.intensity.value = Mathf.Lerp(vignette.intensity.value, 0f, transitionTime * Time.deltaTime);

            StartCoroutine(ChangeScene());
        }
    }

    private void FixedUpdate()
    {
        if (Intro_Jar.instance.jarIsReady == true)
        {
            gameObject.GetComponent<Camera>().backgroundColor = Color.Lerp(colorStart, colorFinish, t);

            if (t < 1)
            {
                t += Time.deltaTime / transitionTime;
            }
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, cameraPositionFinish, transitionTime * Time.deltaTime);

        }

    }


    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("1Intro");
    }
}
