using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamworksInit : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        try
        {
            Steamworks.SteamClient.Init(2321970);
            PrintYourName();
        }
        catch (System.Exception e)
        {

            Debug.Log(e);
        }
    }

    void PrintYourName()
    {
        Debug.Log(Steamworks.SteamClient.Name);
    }
}
