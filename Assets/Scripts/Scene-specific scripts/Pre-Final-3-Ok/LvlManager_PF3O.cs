using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlManager_PF3O : MonoBehaviour
{
    public GameObject lvl2;
    public GameObject lvl3;

    void Start()
    {

        if (SaveManager.instance.activeSave.setHomeFromTower == true)
        {
            lvl2.SetActive(false);
            lvl3.SetActive(true);
        } else
        {
            lvl2.SetActive(true);
            lvl3.SetActive(false);
        }

    }


}
