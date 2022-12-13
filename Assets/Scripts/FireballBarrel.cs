using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBarrel : MonoBehaviour
{
    public GameObject witch;
    public GameObject fireball;
    private Animator witchAnimator;
    private bool fireballSpawned = false;

    // Start is called before the first frame update
    void Start()
    {
        witchAnimator = witch.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (witchAnimator.GetCurrentAnimatorStateInfo(0).IsName("witch_fire"))
        {
            if (fireballSpawned == false)
            {

                Invoke("InstantiateFireball", 0.8f);
                fireballSpawned = !fireballSpawned;
            }

        }
    }

    void InstantiateFireball()
    {
        Instantiate(fireball, gameObject.transform.position, Quaternion.identity);
    }
}
