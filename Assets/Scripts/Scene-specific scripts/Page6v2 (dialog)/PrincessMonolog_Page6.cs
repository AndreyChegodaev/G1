using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_Page6 : MonoBehaviour
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
        if (SaveManager.instance.activeSave.settings_VoiceSwitch == false)
        {
            audioSource.mute = true;
        }
        else audioSource.mute = false;

        if (AudioManager_Page6.instance.currentTrack == AudioManager_Page6.instance.audioClips.Count - 1)
        {
            StartCoroutine(WaitForTrackToEnd());
        }
    }

    IEnumerator WaitForTrackToEnd()
    {
        yield return new WaitForSeconds(AudioManager_Page6.instance.audioSource.clip.length);
        flag = true;
        exclamationMark.SetActive(true);        
    }

    void PrincessLineCondition()
    {
        if (SaveManager.instance.activeSave.dejaVu == 1)
        {
            audioSource.clip = princessLines[0];
        }

        else if (SaveManager.instance.activeSave.dejaVu == 2)
        {
            audioSource.clip = princessLines[1];
        }

        else audioSource.clip = princessLines[2];
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
        yield return new WaitForSeconds(audioSource.clip.length);
        CCManager.instance.Hide();
    }
}
