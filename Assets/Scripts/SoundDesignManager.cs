using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundDesignManager : MonoBehaviour
{
    public AudioClip audioClip;
    public float delay = 0;
    public enum PlaySoundOn
    {
        start,
        collision,
        cameraPosition,
    }
    public PlaySoundOn playSoundOn;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;

        if (playSoundOn == PlaySoundOn.start)
        {
            Invoke("PlaySound", delay);
        }
    }

    private void Update()
    {
        if (SaveManager.instance.activeSave.settings_MusicSwitch == false)
        {
            audioSource.mute = true;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (playSoundOn == PlaySoundOn.collision)
        {
            if (collision.gameObject.tag == "Princess")
            {
                Invoke("PlaySound", delay);
            }
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (playSoundOn == PlaySoundOn.collision)
        {
            if (collision.gameObject.tag == "Princess")
            {
                audioSource.Stop();
            }
        }
    }

    void PlaySound()
    {
        audioSource.Play();
        Invoke("RemoveCollider", audioClip.length);
        Debug.Log("Sound" + gameObject.name + "played");
    }

    void RemoveCollider()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
    }
}
