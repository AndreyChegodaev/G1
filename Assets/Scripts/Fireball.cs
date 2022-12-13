using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    Animator animator;
    GameObject princess;
    public float speed;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        princess = GameObject.FindGameObjectWithTag("Princess");
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, princess.transform.position + Vector3.up * 2, speed * Time.deltaTime);

        if (transform.position == princess.transform.position + Vector3.up * 2)
        {
            animator.SetTrigger("Impact");
            princess.GetComponent<Animator>().SetTrigger("IsHit");
            Invoke("Destroy", 0.4f);
        }
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }

}
