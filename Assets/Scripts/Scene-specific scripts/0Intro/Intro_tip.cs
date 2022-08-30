using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_tip : MonoBehaviour
{
    public int waitToShow;
    public bool readyToShow;
    public float transitionTime = 5f;
    private float t = 0;
    private float t2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        readyToShow = false;
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        if (readyToShow == true)
        {
            FadeIn();
        }

        if (Intro_Jar.instance.ingridientsInJar != 0)
        {
            readyToShow = false;
            FadeOut();
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitToShow);
        
        if (Intro_Jar.instance.ingridientsInJar == 0)
        {
            Debug.Log(Intro_Jar.instance.ingridientsInJar);
            readyToShow = true;
        }


    }

    public void FadeIn()
    {
        GetComponent<SpriteRenderer>().color = Color.Lerp(new Color(1, 1, 1, 0), new Color(1, 1, 1, 1), t);

        if (t < 1)
        {
            t += Time.deltaTime / transitionTime;
        }
    }

    public void FadeOut()
    {

        GetComponent<SpriteRenderer>().color = Color.Lerp(GetComponent<SpriteRenderer>().color, new Color(1, 1, 1, 0), t2);

        if (t2 < 1)
        {
            t2 += Time.deltaTime / transitionTime;
        }
    }
}
