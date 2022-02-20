using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_PS : MonoBehaviour
{
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
        if (AudioManager_PS.instance.currentTrack == AudioManager_PS.instance.audioClips.Count - 1)
        {
            StartCoroutine(WaitForTrackToEnd());
        }
    }

    IEnumerator WaitForTrackToEnd()
    {
        yield return new WaitForSeconds(AudioManager_PS.instance.audioSource.clip.length);
        flag = true;     
    }

    public void TaskOnClick()
    {
        if (flag == true)
        {
            audioSource.Play();
        }
    }

}
