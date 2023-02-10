using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    private Animator anim;
    private AudioSource audioSource;
    public AudioClip blinkSound;
    public int delay = 3;
    private bool soundPlayed = false;



    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
        Invoke("DoBlink", delay);
        
        if (!soundPlayed)
        {
            Invoke("PlaySound", delay);
            soundPlayed = true;
        }

    }

    void DoBlink()
    {
        anim.SetBool("Blink", true);
    }

    void PlaySound()
    {
        audioSource.clip = blinkSound;
        audioSource.PlayOneShot(blinkSound, 0.15f);
    }


}
