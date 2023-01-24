using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager_Page11A : MonoBehaviour
{
    private GameObject wizard;
    private Animator animator;
    void Start()
    {
        wizard = GameObject.Find("InteractiveObjects");
        animator = wizard.GetComponent<Animator>();
        animator.SetBool("ReadyToClose", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogTextManager_Page11A.instance.currentSpawnIndex == 4)
        {
            animator.SetBool("DoorCloses", true);
        }
    }
}
