using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMusicControl : MonoBehaviour
{

    public GameObject backgroundMusic;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic = GameObject.FindWithTag("BackgroundMusic");
        audioSource = backgroundMusic.GetComponent<AudioSource>();
    }

    public void MuteMusic()
    {
        audioSource.mute = !audioSource.mute;
    }

}
