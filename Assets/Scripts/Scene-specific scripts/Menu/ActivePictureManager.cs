using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePictureManager : MonoBehaviour
{
    public static ActivePictureManager instance;

    public List<GameObject> pictures = new List<GameObject>();

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if (SaveManager.instance.activeSave.activePicture == SaveData.ActivePicture.bad_ash) pictures[0].SetActive(true);
        else if (SaveManager.instance.activeSave.activePicture == SaveData.ActivePicture.bad_tower) pictures[1].SetActive(true);
        else if (SaveManager.instance.activeSave.activePicture == SaveData.ActivePicture.ok_back) pictures[2].SetActive(true);
        else if (SaveManager.instance.activeSave.activePicture == SaveData.ActivePicture.ok_tower_man) pictures[3].SetActive(true);
        else if (SaveManager.instance.activeSave.activePicture == SaveData.ActivePicture.goodish) pictures[4].SetActive(true);
        else if (SaveManager.instance.activeSave.activePicture == SaveData.ActivePicture.nothing) pictures[5].SetActive(true);
    }
}
