using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntObjManager_Page4 : MonoBehaviour //don't rename to 3C - for some reason it makes the IDE grumpy
{
    public AudioSource audioSource;
    public AudioClip audioOnHover;
    
    public string header;
    public string content;
    
    private Color initialColor = Color.white;
    public Color hoverColor = Color.green;
    private new SpriteRenderer renderer;
    private bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioOnHover; 
        
        renderer = GetComponent<SpriteRenderer>();
        renderer.color = initialColor;
    }

    private void Update()
    {
        if (SaveManager.instance.activeSave.settings_MusicSwitch == false)
        {
            audioSource.mute = true;
        }
        else audioSource.mute = false;

        if (TextManager_Page4.instance.paragraphs[TextManager_Page4.instance.paragraphs.Count-1].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
        {
            flag = true;
        }
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        if (flag == true) 
        {
            renderer.color = hoverColor;
            TooltipSystem.Show(content, header);

            if (Input.GetMouseButtonDown(0))
            {
                GameManager.instance.Page5_Unlocked();
                gameObject.GetComponent<PageTurner>().TaskOnClick();
            }
        }

    }

    private void OnMouseEnter()
    {
        if (flag == true)
        {
            audioSource.Play();
        }
    }

    private void OnMouseExit()
    {
        if (flag == true)
        {
            renderer.color = initialColor;
            TooltipSystem.Hide();
            audioSource.Stop();
        }
    }
    public void Mute()
    {
        audioSource.mute = !audioSource.mute;
    }

}
