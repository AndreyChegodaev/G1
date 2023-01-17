using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalManager_F1B : MonoBehaviour
{
    public List<GameObject> positions = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        if (SaveManager.instance.activeSave.hasFinger == true)
        {
            positions[0].GetComponent<Renderer>().enabled = true;
            positions[1].GetComponent<Renderer>().enabled = false;
        }
        else
        {
            positions[0].GetComponent<Renderer>().enabled = false;
            positions[1].GetComponent<Renderer>().enabled = true;
        }

        if (SaveManager.instance.activeSave.hasFork == true)
        {
            positions[2].GetComponent<Renderer>().enabled = true;
            positions[3].GetComponent<Renderer>().enabled = false;
        }
        else
        {
            positions[2].GetComponent<Renderer>().enabled = false;
            positions[3].GetComponent<Renderer>().enabled = true;
        }

        if (SaveManager.instance.activeSave.dejaVu != 0)
        {
            positions[4].GetComponent<Renderer>().enabled = true;
            positions[5].GetComponent<Renderer>().enabled = false;
        }
        else
        {
            positions[4].GetComponent<Renderer>().enabled = false;
            positions[5].GetComponent<Renderer>().enabled = true;
        }

        if (SaveManager.instance.activeSave.visitedWitch == true)
        {
            positions[6].GetComponent<Renderer>().enabled = true;
            positions[7].GetComponent<Renderer>().enabled = false;
        }
        else
        {
            positions[6].GetComponent<Renderer>().enabled = false;
            positions[7].GetComponent<Renderer>().enabled = true;
        }

        if (SaveManager.instance.activeSave.killedByWitch == true)
        {
            positions[8].GetComponent<Renderer>().enabled = true;
            positions[9].GetComponent<Renderer>().enabled = false;
        }
        else
        {
            positions[8].GetComponent<Renderer>().enabled = false;
            positions[9].GetComponent<Renderer>().enabled = true;
        }


    }
}
