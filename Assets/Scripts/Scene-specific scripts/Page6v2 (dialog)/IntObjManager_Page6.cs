using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntObjManager_Page6 : MonoBehaviour 
{
    public GameObject blinkPrefab;
    public Transform prefabPosition;
    
    public AudioSource audioSource;
    public AudioClip audioOnHover;

    public string header;
    public string content;

    private Color initialColor = Color.white;
    public Color hoverColor = Color.green;
    private new SpriteRenderer renderer;
    private bool flag = false;
    private bool blinked = false;

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

        choice1 = GameObject.Find("Path");
        choice2 = GameObject.Find("WitchAttack");
        choice3 = GameObject.Find("WitchGreet");

    }

    private void Update()
    {
        if (SaveManager.instance.activeSave.settings_MusicSwitch == false)
        {
            audioSource.mute = true;
        }
        else audioSource.mute = false;

        if (TextManager_Page6.instance.paragraphs[TextManager_Page6.instance.paragraphs.Count - 1].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
        {
            flag = true;
            if (gameObject.activeSelf == true && blinked == false)
            {
                Instantiate(blinkPrefab, prefabPosition.transform);
                blinked = !blinked;
            }
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
                choice1.GetComponent<PolygonCollider2D>().enabled = false;
                choice2.GetComponent<PolygonCollider2D>().enabled = false;
                choice3.GetComponent<PolygonCollider2D>().enabled = false;

                if (gameObject == choice1)
                {
                    gameObject.GetComponent<PageTurner>().TaskOnClick();
                }        
                else if (gameObject == choice2)
                {
                    gameObject.GetComponent<PageTurner>().TaskOnClick();
                    GameManager.instance.KilledByWitch();
                    GameManager.instance.PF2B_Unlocked();
                } 
                else if (gameObject == choice3)
                {
                    GameManager.instance.VisitedWitch();
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
