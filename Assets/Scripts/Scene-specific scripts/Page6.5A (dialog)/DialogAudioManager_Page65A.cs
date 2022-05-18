using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogAudioManager_Page65A : MonoBehaviour
{
    int currentTrack = 0;
    AudioSource audioSource;
    public List<AudioClip> audioClips = new List<AudioClip>();
    public bool stop = false;
    public Button previousTrack;
    public Button nextTrack;


    // Start is called before the first frame update
    void Start()
    {
        Exceptions();
        
        audioSource = GetComponent<AudioSource>();
        StartAudio();
        previousTrack.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (SaveManager.instance.activeSave.settings_VoiceSwitch == false)
        {
            audioSource.mute = true;
        }
        else audioSource.mute = false;

        if (currentTrack == audioClips.Count - 1)
        {
            nextTrack.interactable = false;
        } else
            nextTrack.interactable = true;


        if (currentTrack > 0)
        {
            previousTrack.interactable = true;
        } else
            previousTrack.interactable = false;
    }

    public void StartAudio(int changeMusic = 0)
    {
        currentTrack += changeMusic;
        if (currentTrack >= audioClips.Count)
        {
            currentTrack = 0;
        }
        
        else if (currentTrack < 0)
        {
            currentTrack = audioClips.Count - 1;
        }
       
        if (audioSource.isPlaying && changeMusic == 0)
        {
            return;
        }
        
        if (stop)
        {
            stop = false;
        }


        audioSource.clip = audioClips[currentTrack];
        audioSource.Play();
    }
    public void StopAudio()
    {
        audioSource.Stop();
        stop = true;
    }

    public void MuteAudio()
    {
        audioSource.mute = !audioSource.mute;
    }

    void Exceptions()
    {
        if (SaveManager.instance.activeSave.hasFinger == true)
        {
            audioClips.Remove(audioClips[10]);
            audioClips.Remove(audioClips[10]);
            audioClips.Remove(audioClips[10]);
            audioClips.Remove(audioClips[10]);
            audioClips.Remove(audioClips[10]);
        }
        else
        {
            audioClips.Remove(audioClips[4]);
            audioClips.Remove(audioClips[4]);
            audioClips.Remove(audioClips[4]);
            audioClips.Remove(audioClips[4]);
            audioClips.Remove(audioClips[4]);
            audioClips.Remove(audioClips[4]);
        }
    }
}
