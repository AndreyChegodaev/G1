using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_Page9B_2 : MonoBehaviour
{
    public GameObject exclamationMark;
    public AudioClip[] princessLines;
    AudioSource audioSource;
    private bool flag = false;
    private bool exclamationSpawned = false;

    // Start is called before the first frame update


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    private void Update()
    {
        transform.position = GameObject.FindGameObjectWithTag("Princess").transform.position + Vector3.up * 2;

        if (SaveManager.instance.activeSave.settings_VoiceSwitch == false)
        {
            audioSource.mute = true;
        }
        else audioSource.mute = false;

        if (AudioManager_Page9B.instance.currentTrack == AudioManager_Page9B.instance.audioClips.Count - 2)
        {
            StartCoroutine(WaitForTrackToEnd());

        }
        else if (AudioManager_Page9B.instance.currentTrack == AudioManager_Page9B.instance.audioClips.Count - 1)
        {
            StopCoroutine(WaitToHideCC1());
            audioSource.clip = princessLines[1];
            flag = true;
        }
    }

    IEnumerator WaitForTrackToEnd()
    {
        yield return new WaitForSeconds(AudioManager_Page9B.instance.audioSource.clip.length);
        flag = true;
        exclamationMark.SetActive(true);

        if (exclamationSpawned == false)
        {
            Instantiate(exclamationMark, GameObject.FindGameObjectWithTag("Princess").transform);
            exclamationSpawned = true;
        }
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && flag == true)
        {

            if (AudioManager_Page9B.instance.currentTrack == AudioManager_Page9B.instance.audioClips.Count - 2)
            {
                audioSource.clip = princessLines[0];
                StartCoroutine(WaitToHideCC1());
            }

            else
            {
                audioSource.clip = princessLines[1];
                StartCoroutine(WaitToHideCC2());
            }

            audioSource.Play();
            CCManager_Page9B.instance.Show();

        }
    }

    IEnumerator WaitToHideCC1()
    {
        yield return new WaitForSeconds(audioSource.clip.length);
        CCManager_Page9B.instance.Hide();
    }

    IEnumerator WaitToHideCC2()
    {
        yield return new WaitForSeconds(audioSource.clip.length);
        CCManager_Page9B.instance.Hide();
        if (GameObject.FindGameObjectWithTag("Exclamation") != null)
        {
            GameObject.FindGameObjectWithTag("Exclamation").GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
