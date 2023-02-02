using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessMonolog_PS : MonoBehaviour
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
        transform.position = GameObject.FindGameObjectWithTag("Princess").transform.position + Vector3.up * 2; // 3.

        if (SaveManager.instance.activeSave.settings_VoiceSwitch == false)
        {
            audioSource.mute = true;
        }
        else audioSource.mute = false;

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



   public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && flag == true)
        {
            audioSource.Play();
            CCManager.instance.Show();
            exclamationMark.SetActive(true);
            Instantiate(exclamationMark, GameObject.FindGameObjectWithTag("Princess").transform);
            StartCoroutine(WaitToHideCC());
        }
    }

    IEnumerator WaitToHideCC()
    {
        yield return new WaitForSeconds(princessLine.length);
        CCManager.instance.Hide();
        GameObject.FindGameObjectWithTag("Exclamation").GetComponent<SpriteRenderer>().enabled = false; // 5.

    }

}
