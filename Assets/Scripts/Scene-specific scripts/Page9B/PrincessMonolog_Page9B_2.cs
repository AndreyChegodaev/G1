using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_Page9B_2 : MonoBehaviour
{
    public GameObject exclamationMark;
    public AudioClip princessLine;
    //public Sprite princessTalking;
    AudioSource audioSource;
    private bool flag = false;

    // Start is called before the first frame update


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = princessLine;
    }

    private void Update()
    {
        if (AudioManager_Page9B.instance.currentTrack == 1)
        {
            StartCoroutine(WaitForTrackToEnd());
        }
    }

    IEnumerator WaitForTrackToEnd()
    {
        yield return new WaitForSeconds(AudioManager_Page9B.instance.audioSource.clip.length);
        flag = true;
        exclamationMark.SetActive(true);        
    }



    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && flag == true)
        {
            audioSource.Play();
        }
        
    }
}
