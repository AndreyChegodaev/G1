using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn_F5T : MonoBehaviour
{
    public GameObject fadeIn;
    // Start is called before the first frame update
    void Start()
    {
        fadeIn.GetComponent<Animator>().SetBool("FadeOut", true);
    }
}
