using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class DLCbuyButton : MonoBehaviour
{
    public int DLCiD;
    public bool testInstalled;

    void Start()
    {

        if (Steamworks.SteamApps.IsDlcInstalled(DLCiD) == true || testInstalled == true)
        {
            gameObject.SetActive(false);
        }
    }

    public void TaskOnClick()
    {
        //Steamworks.SteamFriends.OpenStoreOverlay(DLCiD);
        Steamworks.SteamFriends.OpenStoreOverlay(2329372);
    }
}
