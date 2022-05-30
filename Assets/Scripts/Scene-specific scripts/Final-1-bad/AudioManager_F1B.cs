using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioManager_F1B : MonoBehaviour
{
    public static AudioManager_F1B instance;
    
    public int currentTrack = 0;
    public AudioSource audioSource;
    public List<AudioClip> audioClips = new List<AudioClip>();
    public bool stop = false;
    public Button nextTrack;


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

        if (currentTrack == audioClips.Count-1)
        {
            StartCoroutine(ChangeScene());
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
        CCManager_F1B.instance.Show();
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
            audioClips[2] = null;
        }
        else
        {
            audioClips[1] = null;
        }

        if (SaveManager.instance.activeSave.hasFork == true)
        {
            audioClips[4] = null;
        }
        else
        {
            audioClips[3] = null;
        }

        if (SaveManager.instance.activeSave.dejaVu != 0)
        {
            audioClips[6] = null;
        }
        else
        {
            audioClips[5] = null;
        }

        if (SaveManager.instance.activeSave.visitedWitch == true)
        {
            audioClips[8] = null;
        }
        else
        {
            audioClips[7] = null;
        }

        if (SaveManager.instance.activeSave.killedByWitch == true)
        {
            audioClips[10] = null;
        }
        else
        {
            audioClips[9] = null;
        }

        if (SaveManager.instance.activeSave.firstPlaytrough == false)
        {
            audioClips[11] = null;
        }


        audioClips.RemoveAll(item => item == null);
    }

    IEnumerator EnableButton()
    {
        yield return new WaitForSeconds(audioSource.clip.length);

        nextTrack.gameObject.SetActive(true);
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(audioSource.clip.length + 3);

        GameManager.instance.StartNewGame();
        SceneManager.LoadScene("MainMenu");
    }
}
