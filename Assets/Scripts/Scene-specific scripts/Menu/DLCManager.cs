using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Steamworks;

public class DLCManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject certificate;
    public Sprite pictureBought;
    public int DLCiD;

    public bool testInstalled;

    private void Start()
    {
        if (Steamworks.SteamApps.IsDlcInstalled(DLCiD) == true || testInstalled == true)
        {
            gameObject.GetComponent<Image>().sprite = pictureBought;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Steamworks.SteamApps.IsDlcInstalled(DLCiD) == true || testInstalled == true)
        {
            certificate.SetActive(true);
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (Steamworks.SteamApps.IsDlcInstalled(DLCiD) == true || testInstalled == true)
        {
            certificate.SetActive(false);
        }
    }
}
