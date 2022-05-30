using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioManager_F3O : MonoBehaviour
{
    public static AudioManager_F3O instance;
    
    public int currentTrack;
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

        if (currentTrack == audioClips.Count - 1)
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
        CCManager_F3O.instance.Show();
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
            audioClips[1] = null;
        } else audioClips[0] = null;

        if (SaveManager.instance.activeSave.hasFinger == true)
        {
            audioClips[3] = null;
        }
        else audioClips[2] = null;

        if (SaveManager.instance.activeSave.hasFork == true)
        {
            audioClips[5] = null;
        }
        else audioClips[4] = null;

        if (SaveManager.instance.activeSave.dejaVu != 0)
        {
            audioClips[7] = null;
        }
        else audioClips[6] = null;

        if (SaveManager.instance.activeSave.visitedWitch == true)
        {
            audioClips[9] = null;
        }
        else audioClips[8] = null;

        if (SaveManager.instance.activeSave.crossedRavine == true)
        {
            audioClips[11] = null;
        }
        else audioClips[10] = null;


        if (SaveManager.instance.activeSave.crossedRavine == true && SaveManager.instance.activeSave.waitAtTheDoor >= 4)
        {
            audioClips[12] = null;
            audioClips[14] = null;
        }
        else if (SaveManager.instance.activeSave.crossedRavine == true && SaveManager.instance.activeSave.waitAtTheDoor < 4)
        {
            audioClips[13] = null;
            audioClips[14] = null;
        }
        else if (SaveManager.instance.activeSave.crossedRavine == false)
        {
            audioClips[12] = null;
            audioClips[13] = null;
        }
       
        if (SaveManager.instance.activeSave.keptTheRing == true)
        {
            audioClips[16] = null;
        }
        else audioClips[15] = null;

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
