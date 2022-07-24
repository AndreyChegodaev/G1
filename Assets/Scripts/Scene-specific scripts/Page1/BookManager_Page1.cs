using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookManager_Page1 : MonoBehaviour
{
    public static BookManager_Page1 instance;
    
    public GameObject bookUI;
    public GameObject bookText;
    public AudioClip openBook;
    //public AudioClip foldingPage;

    public bool bookShowFirstIllustration = false;
    public bool bookShowOther = false;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        bookShowFirstIllustration = false;
        bookShowOther = false;

        bookUI.SetActive(false);
        bookText.SetActive(false);
        gameObject.GetComponent<Animator>().SetBool("IsOpening", true);
        gameObject.GetComponent<AudioSource>().clip = openBook;
        gameObject.GetComponent<AudioSource>().Play();
        StartCoroutine(ShowUI());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShowUI()
    {
        yield return new WaitForSeconds(1.5f);
        bookShowFirstIllustration = true;
        bookShowOther = true;
        bookUI.SetActive(true);
        bookText.SetActive(true);
    }
}
