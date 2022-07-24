using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BookCloser : MonoBehaviour
{
    public static BookCloser instance;

    public float timer;
    
    public Image curtain;
    public GameObject book;
    public GameObject text;
    public GameObject bookUI;

    public string sceneName;
    public Camera illustrationCamera;



    public void Awake()
    {
        instance = this;
    }

    public void TaskOnClick()
    {
        StartCoroutine(CurtainFadeIn());
        SaveManager.instance.activeSave.currentLevel = sceneName;
        SaveManager.instance.Save();
    }

    IEnumerator CurtainFadeIn()
    {
        curtain.CrossFadeAlpha(1f, timer, false);
        yield return new WaitForSeconds(timer);

        illustrationCamera.enabled = false;

        StartCoroutine(CloseAnimation());
    }

    IEnumerator CloseAnimation()
    {
        SelectPageCameraMover.instance.TaskOnClick();
        text.transform.position = new Vector3(text.transform.position.x, text.transform.position.y - 1000); // I know, it's lame: I just teleport the text far away
        bookUI.SetActive(false);
        book.GetComponent<Animator>().SetBool("IsClosing", true);
        book.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(sceneName);


    }
}
