using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Intro_logo : MonoBehaviour
{

    public Sprite logoBitten;
    public GameObject littlePiece;
    public GameObject audioContainer;
    public AudioClip soundOnAwake;


    public float transitionTime = 1f;
    public string sceneToLoad;
    public bool clickHappened = false;
    private float t = 0f;


    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0);
        gameObject.GetComponent<AudioSource>().clip = soundOnAwake;
        gameObject.GetComponent<AudioSource>().Play();
        littlePiece.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0);
        littlePiece.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(new Color(1f, 1f, 1f, 0), Color.white, t);

        if (t < 1)
        {
            t += Time.deltaTime / transitionTime;
        }

        if (Input.GetKeyDown("space") || clickHappened == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = logoBitten;
            littlePiece.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            littlePiece.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            audioContainer.SetActive(true);
            StartCoroutine(ChangeScene());
        }

    }



    private void OnMouseDown()
    {
        clickHappened = true;
    }

    IEnumerator ChangeScene()
    {
        Intro_Fader.instance.fadeOutReady = true;
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(sceneToLoad);
    }

}
