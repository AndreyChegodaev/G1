using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_Page8 : MonoBehaviour
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

        if (AudioManager_Page8.instance.currentTrack == AudioManager_Page8.instance.audioClips.Count - 1)
        {
            StartCoroutine(WaitForTrackToEnd());
        }
    }

    IEnumerator WaitForTrackToEnd()
    {
        yield return new WaitForSeconds(AudioManager_Page8.instance.audioSource.clip.length);
        flag = true;
        exclamationMark.SetActive(true);
    }

    void PrincessLineCondition()
    {
        if (SaveManager.instance.activeSave.hasFinger == true && SaveManager.instance.activeSave.heardVoice == false)
        {
            audioSource.clip = princessLines[0];
        }

        else if (SaveManager.instance.activeSave.hasFinger == true && SaveManager.instance.activeSave.heardVoice == true)
        {
            audioSource.clip = princessLines[2];
        }

        else audioSource.clip = princessLines[1];
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
