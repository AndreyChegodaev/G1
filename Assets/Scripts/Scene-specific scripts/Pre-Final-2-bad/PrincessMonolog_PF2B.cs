using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_PF2B : MonoBehaviour
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
        if (SaveManager.instance.activeSave.settings_VoiceSwitch == false)
        {
            audioSource.mute = true;
        }
        else audioSource.mute = false;

        if (AudioManager_PF2B.instance.currentTrack == AudioManager_PF2B.instance.audioClips.Count - 2)
        {
            StartCoroutine(WaitForTrackToEnd());
        }
    }

    IEnumerator WaitForTrackToEnd()
    {
        yield return new WaitForSeconds(AudioManager_PF2B.instance.audioSource.clip.length);
        flag = true;
        exclamationMark.SetActive(true);
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && flag == true)
        {
            audioSource.Play();
            CCManager.instance.Show();
            StartCoroutine(WaitToHideCC());
        }
    }

    IEnumerator WaitToHideCC()
    {
        yield return new WaitForSeconds(princessLine.length);
        CCManager.instance.Hide();
    }
}
