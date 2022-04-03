using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_PS : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip princessLine;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = princessLine;
        
    }


    public void TaskOnClick()
    {
        audioSource.Play();
        CCManager.instance.Show();
        StartCoroutine(WaitToHideCC());
    }


    IEnumerator WaitToHideCC()
    {
        yield return new WaitForSeconds(princessLine.length);
        CCManager.instance.Hide();
    }

}
