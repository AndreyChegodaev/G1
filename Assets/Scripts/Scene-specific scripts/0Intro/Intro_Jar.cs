using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_Jar : MonoBehaviour
{
    public static Intro_Jar instance;

    public AudioClip moveSound;

    public bool waterInJar;
    public bool magicInJar;

    public int ingridientsInJar;
    public bool jarIsReady;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        magicInJar = false;
        waterInJar = false;
        jarIsReady = false;
        ingridientsInJar = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ingridient")
        {
            ingridientsInJar ++;
            Intro_lense.instance.lenseReady = true;

        }

        if (collision.gameObject.name == "Water" && collision.gameObject.tag == "Ingridient")
        {
            waterInJar = true;
            //Debug.Log("Water in jar");
        }

        if (collision.gameObject.name == "Magic" && collision.gameObject.tag == "Ingridient")
        {
            magicInJar = true;
            //Debug.Log("Magic in jar");
        }

        if (ingridientsInJar >= 5)
        {
            UnlockAchievement();
            StartCoroutine(Wait());

        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        jarIsReady = true;
        gameObject.GetComponent<Animator>().SetBool("JarIsReady", true);
        gameObject.GetComponent<AudioSource>().clip = moveSound;
        gameObject.GetComponent<AudioSource>().Play();
    }

    void UnlockAchievement()
    {
        var achievement = new Steamworks.Data.Achievement("ACHIEVEMENT_Qualified").Trigger();
    }
}
