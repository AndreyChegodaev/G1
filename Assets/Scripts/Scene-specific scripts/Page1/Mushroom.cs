using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public static Mushroom instance;

    public bool collisionWithMushroom;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        collisionWithMushroom = false;
    }

    void Update()
    {
        if (collisionWithMushroom == true) Destroy(gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Princess")
        {
            collisionWithMushroom = true;
        }
    }

}
