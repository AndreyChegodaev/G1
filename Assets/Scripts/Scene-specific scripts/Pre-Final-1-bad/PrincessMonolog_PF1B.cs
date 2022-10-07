using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_PF1B : MonoBehaviour
{
    public GameObject exclamationMark;
    public AudioClip[] princessLines;
    //public Sprite princessTalking;
    AudioSource audioSource;
    private bool flag = false;
    private bool exclamationSpawned = false; // 2. 

    // Start is called before the first frame update


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        PrincessLineCondition();

    }

    private void Update()
    {
        transform.position = GameObject.FindGameObjectWithTag("Princess").transform.position + Vector3.up * 2; // 3.

        if (SaveManager.instance.activeSave.settings_VoiceSwitch == false)
        {
            audioSource.mute = true;
        }
        else audioSource.mute = false;

        if (AudioManager_PF1B.instance.currentTrack == AudioManager_PF1B.instance.audioClips.Count - 2)
        {
            StartCoroutine(WaitForTrackToEnd());
        }
    }

    IEnumerator WaitForTrackToEnd()
    {
        yield return new WaitForSeconds(AudioManager_PF1B.instance.audioSource.clip.length);
        flag = true;
        exclamationMark.SetActive(true);

        if (exclamationSpawned == false) // 4.
        {
            Instantiate(exclamationMark, GameObject.FindGameObjectWithTag("Princess").transform);
            exclamationSpawned = true;
        }
    }

    void PrincessLineCondition()
    {
       if (SaveManager.instance.activeSave.hasFinger == true)
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
            CCManager_PF1B.instance.Show();
            StartCoroutine(WaitToHideCC());
        }
    }

    IEnumerator WaitToHideCC()
    {
        yield return new WaitForSeconds(audioSource.clip.length);
        CCManager_PF1B.instance.Hide();
        GameObject.FindGameObjectWithTag("Exclamation").GetComponent<SpriteRenderer>().enabled = false; // 5.

    }
}
