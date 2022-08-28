using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro_SpriteSwap : MonoBehaviour
{

    public Sprite idle;
    public Sprite hover;
    public bool mouseOverObject = false;


    private void OnMouseEnter()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = hover;
        mouseOverObject = true;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = idle;
        mouseOverObject = false;
    }


}
