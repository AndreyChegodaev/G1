using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class DLCbuyButton : MonoBehaviour
{
    public AppId DLCiD;
    public int ID;
    //public bool testInstalled;

    void Start()
    {
        DLCiD = ID;

        if (Steamworks.SteamApps.IsDlcInstalled(DLCiD) == true /*|| testInstalled == true*/ )
        {
            gameObject.SetActive(false);
        }
    }

    public void TaskOnClick()
    {
        Steamworks.SteamFriends.OpenStoreOverlay(DLCiD);
    }
}
