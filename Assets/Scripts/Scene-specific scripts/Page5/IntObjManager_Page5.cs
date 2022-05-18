using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntObjManager_Page5 : MonoBehaviour 
{
    public AudioSource audioSource;
    public AudioClip audioOnHover;

    public string header;
    public string content;

    private Color initialColor = Color.white;
    public Color hoverColor = Color.green;
    private new SpriteRenderer renderer;
    private bool flag = false;

    private GameObject choice1;
    private GameObject choice2;
    private GameObject choice3v1;
    private GameObject choice3v2;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioOnHover;

        renderer = GetComponent<SpriteRenderer>();
        renderer.color = initialColor;

        choice1 = GameObject.Find("Bridge 1");
        choice2 = GameObject.Find("Bridge 2");
        choice3v1 = GameObject.Find("Woods v1");
        choice3v2 = GameObject.Find("Woods v2");
    }

    private void Update()
    {
        if (SaveManager.instance.activeSave.settings_MusicSwitch == false)
        {
            audioSource.mute = true;
        }
        else audioSource.mute = false;

        if (TextManager_Page5.instance.paragraphs[TextManager_Page5.instance.paragraphs.Count - 1].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
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
                gameObject.GetComponent<PageTurner>().TaskOnClick();
                if (gameObject == choice1)
                {
                    GameManager.instance.Page55B_Unlocked();
                }

                else if (gameObject == choice2)
                {
                    GameManager.instance.Page55A_Unlocked();
                }

                else if (gameObject == choice3v1)
                {
                    GameManager.instance.DejaVu();
                    GameManager.instance.Page6v1_Unlocked();
                }
                
                else if (gameObject == choice3v2)
                {
                    GameManager.instance.DejaVu();
                    GameManager.instance.Page6v2_Unlocked();
                }
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
