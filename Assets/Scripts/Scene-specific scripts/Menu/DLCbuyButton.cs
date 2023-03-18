using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class DLCbuyButton : MonoBehaviour
{
    public Steamworks.AppId_t DLCiD;
    public uint ID;
    //public bool testInstalled;

    void Start()
    {
        //DLCiD = ID;
        DLCiD = new Steamworks.AppId_t(ID);

    if (Steamworks.SteamApps.BIsDlcInstalled(DLCiD) == true)
    {
        gameObject.SetActive(false);
    }
}

    public void TaskOnClick()
    {
        SteamFriends.ActivateGameOverlayToStore(DLCiD,  EOverlayToStoreFlag.k_EOverlayToStoreFlag_AddToCart);
        //Steamworks.SteamFriends.OpenStoreOverlay(DLCiD);
    }
}
