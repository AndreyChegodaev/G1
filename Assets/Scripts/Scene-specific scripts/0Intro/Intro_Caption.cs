using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro_Caption : MonoBehaviour
{
    public string caption;
    public GameObject captionContainer;

    public bool jarCollision = false;

    private void OnMouseEnter()
    {
        captionContainer.GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        captionContainer.GetComponent<TMPro.TextMeshProUGUI>().text = caption;
    }

    private void OnMouseExit()
    {
        captionContainer.GetComponent<TMPro.TextMeshProUGUI>().enabled = false;
        captionContainer.GetComponent<TMPro.TextMeshProUGUI>().text = caption;
    }

    private void Update()
    {
        if (jarCollision == true)
        {
            caption = null;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Jar")
        {
            jarCollision = true;
        }
    }

}
