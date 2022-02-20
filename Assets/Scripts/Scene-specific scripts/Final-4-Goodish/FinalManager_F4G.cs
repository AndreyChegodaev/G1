using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalManager_F4G : MonoBehaviour
{
    public List<GameObject> positions = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        if (SaveManager.instance.activeSave.dejaVu != 0)
        {
            positions[2].GetComponent<Renderer>().enabled = true;
            positions[3].GetComponent<Renderer>().enabled = false;
        }
        else
        {
            positions[2].GetComponent<Renderer>().enabled = false;
            positions[3].GetComponent<Renderer>().enabled = true;
        }


    }
}
