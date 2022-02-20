using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_Page5v2 : MonoBehaviour
{
    public GameObject exclamationMark;
    public AudioClip[] princessLines;
    //public Sprite princessTalking;
    AudioSource audioSource;
    private bool flag = false;

    // Start is called before the first frame update


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        PrincessLineCondition();
    }

    private void Update()
    {
        if (AudioManager_Page5v2.instance.currentTrack == AudioManager_Page5v2.instance.audioClips.Count - 1)
        {
            StartCoroutine(WaitForTrackToEnd());
        }
    }

    IEnumerator WaitForTrackToEnd()
    {
        yield return new WaitForSeconds(AudioManager_Page5v2.instance.audioSource.clip.length);
        flag = true;
        exclamationMark.SetActive(true);        
    }

    void PrincessLineCondition()
    {
        if (SaveManager.instance.activeSave.hasFinger == false)
        {
            audioSource.clip = princessLines[0];
        }

        else audioSource.clip = princessLines[1];
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && flag == true)
        {
            audioSource.Play();
        }
        
    }
}
