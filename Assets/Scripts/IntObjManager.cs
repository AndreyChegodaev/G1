using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntObjManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioOnHover;
    
    public string header;
    public string content;
    
    private Color initialColor = Color.white;
    public Color hoverColor = Color.green;
    private new SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioOnHover; 
        
        renderer = GetComponent<SpriteRenderer>();
        renderer.color = initialColor;
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        renderer.color = hoverColor;
        TooltipSystem.Show(content, header);

        if (Input.GetMouseButtonDown(0))
        {
            PageTurner.instance.TaskOnClick();
        }
    }

    private void OnMouseEnter()
    {
        audioSource.Play();
    }

    private void OnMouseExit()
    {
        renderer.color = initialColor;
        TooltipSystem.Hide();
        audioSource.Stop();
    }
    public void Mute()
    {
        audioSource.mute = !audioSource.mute;
    }

}
