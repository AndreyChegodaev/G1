using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour
{
    public int fallMinTime;
    
    private int fallTimer;
    private float elapsedTimeFall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTimeFall += Time.deltaTime;

        if (elapsedTimeFall >= fallTimer)
        {
            StopFalling();
            elapsedTimeFall = 0;
        }
    }

    void StopFalling()
    {
        fallTimer = Random.Range(fallMinTime, fallMinTime+4);

        StartCoroutine(Freeze());
        
        StartCoroutine(DestroyLeaf());
    }

    IEnumerator Freeze()
    {
        yield return new WaitForSeconds(fallTimer);
        gameObject.GetComponent<Animator>().SetBool("IsFalling", false);
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
    }

    IEnumerator DestroyLeaf()
    {
        yield return new WaitForSeconds(fallTimer + 4);
        Destroy(gameObject);
    }
}
