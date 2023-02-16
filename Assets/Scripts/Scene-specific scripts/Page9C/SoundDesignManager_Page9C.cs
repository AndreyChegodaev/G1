using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDesignManager_Page9C : MonoBehaviour
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
    public AudioSource audioSource;
    private CameraManager_Page9B camManager;
    public int cameraPosition;
    private bool clipPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        camManager = GameObject.Find("CameraManager").GetComponent<CameraManager_Page9B>();
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

        if (playSoundOn == PlaySoundOn.cameraPosition)
        {
            if (camManager.currentCamPosition == cameraPosition)
            {
                Invoke("PlaySound", delay);
            }
            else audioSource.Stop();
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
        if (audioSource != null)
        {
            if (clipPlayed == false)
            {
                audioSource.Play();
                Debug.Log("Sound " + gameObject.name + " played");
                clipPlayed = !clipPlayed;
            }

            Invoke("RemoveCollider", audioClip.length);

        }
    }

    void RemoveCollider()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
    }
}
