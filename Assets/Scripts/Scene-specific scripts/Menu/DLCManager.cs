using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DLCManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject certificate;
    public Sprite pictureBought;
    public Steamworks.AppId_t DLCiD;
    public uint ID;
    //public bool testInstalled;

    private void Start()
    {
        DLCiD = new Steamworks.AppId_t(ID);

        if (Steamworks.SteamApps.BIsDlcInstalled(DLCiD) == true)
        {
            gameObject.GetComponent<Image>().sprite = pictureBought;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Steamworks.SteamApps.BIsDlcInstalled(DLCiD) == true)
        {
            certificate.SetActive(true);
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (Steamworks.SteamApps.BIsDlcInstalled(DLCiD) == true)
        {
            certificate.SetActive(false);
        }
    }
}
