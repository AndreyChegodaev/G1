using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Awake()
    {
        GameObject[] backgroundMusic = GameObject.FindGameObjectsWithTag("BackgroundMusic");
        if (backgroundMusic.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void MuteMusic()
    {
        audioSource.mute = !audioSource.mute;
    }
}
