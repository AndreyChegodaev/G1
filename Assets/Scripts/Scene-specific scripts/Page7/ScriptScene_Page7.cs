using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_Page7 : MonoBehaviour
{
    public string[] animationNames;
    public Camera illustrationCamera;
    int currentAnimation;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {

        anim = gameObject.GetComponent<Animator>();
        currentAnimation = 0;
        anim.Play(animationNames[currentAnimation]);
    }


    public void TaskOnClick()
    {
        if (currentAnimation <= animationNames.Length - 1)
        {
            currentAnimation++;
            anim.Play(animationNames[currentAnimation]);
        }

    }


}
