using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager_F5T : MonoBehaviour
{
    public static AudioManager_F5T instance;
    
    public int currentTrack = 0;
    public AudioSource audioSource;
    public List<AudioClip> audioClips = new List<AudioClip>();
    public bool stop = false;
    public Button nextTrack;
    public Button endStory;

    private bool flag = false; // used for enabling the End Story button through coroutine


    // Start is called before the first frame update
    private void Awake()
    {
        instance = this; 
    }

    void Start()
    {
        Exceptions();

        nextTrack.gameObject.SetActive(false);

        audioSource = GetComponent<AudioSource>();
        StartAudio();

        if (currentTrack == 0)
        {
            StartCoroutine(EnableButton());
        }
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
            nextTrack.GetComponent<Image>().enabled = false;
        } else
            nextTrack.interactable = true;
       
        //turns on the EndStory button
        if (currentTrack != 0 && nextTrack.interactable == false)
        {
            flag = true;
            StartCoroutine(EnableButton());
        }
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
        CCManager_F5T.instance.Show();

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
        if (SaveManager.instance.activeSave.heardVoice == true)
        {
            audioClips[2] = null;
        }
        else audioClips[1] = null;

        audioClips.RemoveAll(item => item == null);
    }

    IEnumerator EnableButton()
    {
        yield return new WaitForSeconds(audioSource.clip.length);

        nextTrack.gameObject.SetActive(true);

        if (flag == true)
        {
            nextTrack.gameObject.SetActive(false);
            endStory.gameObject.SetActive(true);
        }

    }
}
