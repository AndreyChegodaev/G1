using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page9C : MonoBehaviour
{
    public string[] animationNames;
    public Camera illustrationCamera;
    int currentAnimation;
    Animator anim;
  
    private GameObject man;
    Animator manAnim;

    private SoundDesignManager_Page9C soundDesign;

    // Start is called before the first frame update
    void Start()
    {

        anim = gameObject.GetComponent<Animator>();
        man = GameObject.Find("Man");
        manAnim = man.GetComponent<Animator>();
        currentAnimation = 0;
        anim.Play(animationNames[currentAnimation]);
        soundDesign = GameObject.Find("SnapSound").GetComponent<SoundDesignManager_Page9C>();

    }


    private void Update()
    {
        if (AudioManager_Page9C.instance.currentTrack == AudioManager_Page9C.instance.audioClips.Count - 1)
        {
            Invoke("OhSnap", AudioManager_Page9C.instance.audioSource.clip.length - 2);
        }
    }


    public void TaskOnClick()
    {
        if (currentAnimation <= animationNames.Length - 1)
        {
            currentAnimation++;
            anim.Play(animationNames[currentAnimation]);
        }

    }

    void OhSnap()
    {
        manAnim.SetBool("OhSnap", true);
        soundDesign.audioSource.Stop();
    }
}
