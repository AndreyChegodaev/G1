using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAudioContainer : MonoBehaviour
{
    public AudioClip[] audioClips;
    private int randomClip;
    // Start is called before the first frame update
    void Start()
    {
        randomClip = Random.Range(0, audioClips.Length);
        gameObject.gameObject.GetComponent<AudioSource>().clip = audioClips[randomClip];
        gameObject.GetComponent<AudioSource>().Play();
    }
}
