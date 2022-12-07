using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene_55A : MonoBehaviour
{
    public string[] animationNames;
    public Camera illustrationCamera;
    int currentAnimation;
    bool flag1 = false;
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

            if (currentAnimation == 1)
            {
                StartCoroutine(Shake1());
            }

            if (currentAnimation == 2)
            {
                flag1 = !flag1;
                StartCoroutine(Shake2());
            }
        }

    }

    IEnumerator Shake1()
    {

        yield return new WaitForSeconds(7.3f);
        if (flag1 == false)
            illustrationCamera.GetComponent<StressReceiver>().InduceStress(0.4f);

    }

    IEnumerator Shake2()
    {
        yield return new WaitForSeconds(1.2f);
        illustrationCamera.GetComponent<StressReceiver>().InduceStress(0.7f);
    }

}
