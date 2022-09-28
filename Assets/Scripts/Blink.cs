using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    private Animator anim;
    private AudioSource audioSource;
    public AudioClip blinkSound;
    public float delay;
    private bool soundPlayed = false;


    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (CameraManager.instance.currentCamPosition == CameraManager.instance.lensOnPosition)
        {
            Invoke ("DoBlink", delay);
            
            if (!soundPlayed)
            {
                Invoke ("PlaySound", delay);
                soundPlayed = true;
            }
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
