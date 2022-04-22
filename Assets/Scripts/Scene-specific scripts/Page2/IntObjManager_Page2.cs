using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntObjManager_Page2 : MonoBehaviour
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


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioOnHover; 
        
        renderer = GetComponent<SpriteRenderer>();
        renderer.color = initialColor;

        choice1 = GameObject.Find("Skeleton");
        choice2 = GameObject.Find("Finger");
        choice3 = GameObject.Find("Ring");
    }

    private void Update()
    {
        if (TextManager_Page2.instance.paragraphs[TextManager_Page2.instance.paragraphs.Count-1].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
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
                    GameManager.instance.HasFork();
                    GameManager.instance.OnTree();
                    GameManager.instance.Page3B_Unlocked(); 
                }

                else if (gameObject == choice2)
                {
                    GameManager.instance.HasFinger();
                    GameManager.instance.Page3C_Unlocked();
                }

                else if (gameObject == choice3)
                {
                    GameManager.instance.Page3A_Unlocked();
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
