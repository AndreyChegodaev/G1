using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDesignController_Page3A : MonoBehaviour
{
    public GameObject jump;
    public GameObject finger;

    // Start is called before the first frame update
    void Start()
    {
        finger.GetComponent<Collider2D>().enabled = false;
       
        if (SaveManager.instance.activeSave.onTree == false)
        {
            Destroy(jump);
        }

    }

}
