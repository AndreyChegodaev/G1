using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_PF3O : MonoBehaviour
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
        if (AudioManager_PF3O.instance.currentTrack == AudioManager_PF3O.instance.audioClips.Count - 1)
        {
            StartCoroutine(WaitForTrackToEnd());
        }
    }

    IEnumerator WaitForTrackToEnd()
    {
        yield return new WaitForSeconds(AudioManager_PF3O.instance.audioSource.clip.length);
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
