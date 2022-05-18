using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_Page9A : MonoBehaviour
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

        if (SaveManager.instance.activeSave.waitAtTheDoor != 4 && AudioManager_Page9A.instance.currentTrack == AudioManager_Page9A.instance.audioClips.Count - 1)
        {
            StartCoroutine(WaitForTrackToEnd());
        }
        else if (SaveManager.instance.activeSave.waitAtTheDoor == 4)
        {
            flag = true;
            exclamationMark.SetActive(true);
        }
    }

    IEnumerator WaitForTrackToEnd()
    {
        yield return new WaitForSeconds(AudioManager_Page9A.instance.audioSource.clip.length);
        flag = true;
        exclamationMark.SetActive(true);
    }

    void PrincessLineCondition()
    {
        if (SaveManager.instance.activeSave.waitAtTheDoor <= 1)
        {
            audioSource.clip = princessLines[0];
            Debug.Log("Princess line 0");
        }

        else if (SaveManager.instance.activeSave.waitAtTheDoor == 2)
        {
            audioSource.clip = princessLines[1];
            Debug.Log("Princess line 1");
        }

        else if (SaveManager.instance.activeSave.waitAtTheDoor == 3)
        {
            audioSource.clip = princessLines[2];
            Debug.Log("Princess line 2");
        } 
        else
        {
            audioSource.clip = princessLines[3];
            Debug.Log("Princess line 3");
        }

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
