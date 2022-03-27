using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntObjManager_Page65A : MonoBehaviour 
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
    private GameObject choice3;
    private GameObject choice4;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioOnHover;

        renderer = GetComponent<SpriteRenderer>();
        renderer.color = initialColor;

        choice1 = GameObject.Find("Witch");

    }

    private void Update()
    {
        if (TextManager_Page65A.instance.paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
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

                if (gameObject == choice1)
                {
                    gameObject.GetComponentInChildren<DialogCanvasManager>().StartDialog();
                    AudioManager_Page6.instance.StopAudio();
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
