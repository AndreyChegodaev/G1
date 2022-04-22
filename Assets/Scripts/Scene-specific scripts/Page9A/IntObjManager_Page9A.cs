using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntObjManager_Page9A : MonoBehaviour 
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
    private GameObject choice5;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioOnHover;

        renderer = GetComponent<SpriteRenderer>();
        renderer.color = initialColor;

        choice1 = GameObject.Find("Path");
        choice2 = GameObject.Find("Door");
        choice3 = GameObject.Find("Bushes");
        choice4 = GameObject.Find("Doormat");
        choice5 = GameObject.Find("Man");
    }

    private void Update()
    {
        if (SaveManager.instance.activeSave.waitAtTheDoor > 3)
        {
            flag = true;
        }

       else if (TextManager_Page9A.instance.paragraphs[TextManager_Page9A.instance.paragraphs.Count - 1].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
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
                    GameManager.instance.PF3O_2_Unlocked();
                    GameManager.instance.SetHomeFromTower();
                } 
                else if (gameObject == choice2)
                {
                    GameManager.instance.Page9A_Unlocked();
                    GameManager.instance.WaitAtTheDoor();
                }
                else if (gameObject == choice3)
                {
                    GameManager.instance.Page9B_Unlocked();
                }
                else if (gameObject == choice4)
                {
                    GameManager.instance.Page9C_Unlocked();
                }
                else if (gameObject == choice5)
                {
                    GameManager.instance.Page10_Unlocked();
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
