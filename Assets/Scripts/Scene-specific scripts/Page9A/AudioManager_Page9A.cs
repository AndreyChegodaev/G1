using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager_Page9A : MonoBehaviour
{
    public static AudioManager_Page9A instance;
    
    public int currentTrack = 0;
    public AudioSource audioSource;
    public List<AudioClip> audioClips = new List<AudioClip>();
    public bool stop = false;
    public Button previousTrack;
    public Button nextTrack;


    // Start is called before the first frame update
    private void Awake()
    {
        instance = this; 
    }

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
        if (SaveManager.instance.activeSave.waitAtTheDoor <= 1)
        {
            audioClips[1] = null;
            audioClips[2] = null;
            audioClips.RemoveAll(item => item == null);
        }

        else if (SaveManager.instance.activeSave.waitAtTheDoor == 2)
        {
            audioClips[0] = null;
            audioClips[2] = null;
            audioClips.RemoveAll(item => item == null);
        }

        else if (SaveManager.instance.activeSave.waitAtTheDoor == 3)
        {
            audioClips[0] = null;
            audioClips[1] = null;
            audioClips.RemoveAll(item => item == null);
        }

        else
        {
            nextTrack.interactable = false;
            previousTrack.interactable = false;
            audioClips[0] = null;
            audioClips[1] = null;
            audioClips[2] = null;
            audioClips[3] = null;
            audioClips.RemoveAll(item => item == null);
        }
    }
}
