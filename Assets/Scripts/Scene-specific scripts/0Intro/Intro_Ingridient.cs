using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_Ingridient : MonoBehaviour
{
    public static Intro_Ingridient instance;
 

    private Vector3 originalPosition;
    private Vector3 mousePosition;

    [Header("0 - pick, 1 - dry, 2 - splash")]
    public AudioClip[] audioClips;

    public Transform jar;
   
    [Header("0 - dry, 1 - wet")]
    public Sprite[] sprites;


    public float moveSpeed = 5f;
    public bool mouseDown = false;
    public bool jarCollision = false;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseDown == true)
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

        } else transform.position = Vector2.Lerp(transform.position, originalPosition, moveSpeed * Time.deltaTime);



        if (jarCollision == true)
        {
            if (gameObject.name == "Water")
            {
                transform.position = jar.transform.position + Vector3.forward;
            }

            else if (gameObject.name == "Salt")
            {
                transform.position = jar.transform.position + Vector3.forward * 2;
            }

            else if (gameObject.name == "Sword")
            {
                transform.position = jar.transform.position + Vector3.forward * 3;
            }

            else if (gameObject.name == "Dill")
            {
                transform.position = jar.transform.position + Vector3.forward * 4;
            }

            else if (gameObject.name == "Magic")
            {
                transform.position = jar.transform.position + Vector3.forward * 5;
            }


            if (Intro_Jar.instance.waterInJar == false)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
            }
            else gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];

        }

    }

    private void OnMouseDown()
    {
        mouseDown = true;
        gameObject.GetComponent<AudioSource>().clip = audioClips[0];
        gameObject.GetComponent<AudioSource>().Play();

    }

    private void OnMouseUpAsButton()
    {
        mouseDown = false;

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Jar")
        {
            Debug.Log("collision with Jar");
            jarCollision = true;
            
            if (Intro_Jar.instance.waterInJar == false)
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(audioClips[1]);
            }

            else
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(audioClips[2]);
            }
        }
    }

}
