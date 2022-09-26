using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leafblower : MonoBehaviour
{
    public static Leafblower instance;
    
    public float force;
    public float radius;
    public float countDown;
    public LayerMask objectsToblow;
    public bool readyToBlow;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        readyToBlow = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (readyToBlow == true)
        {
            StartCoroutine(Blow());
        }
    }

    IEnumerator Blow()
    {
        yield return new WaitForSeconds(countDown);

        readyToBlow = true;

        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, radius, objectsToblow); //OverlapCircleAll checks if a Collider falls within a circular area.

        foreach (Collider2D obj in objects)
        {
            Vector2 direction = obj.transform.position - transform.position;

            obj.GetComponent<Rigidbody2D>().AddForce(direction * force);
        }
    }

    void OnDrawGizmosSelected() // Draws the gizmo of the blow radius 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
