using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class SteamworksBackground : MonoBehaviour
{
    protected Callback<GameOverlayActivated_t> m_GameOverlayActivated;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void OnEnable()
    {
        if (SteamManager.Initialized)
        {
            m_GameOverlayActivated = Callback<GameOverlayActivated_t>.Create(OnGameOverlayActivated);
        }
    }

    private void OnGameOverlayActivated(GameOverlayActivated_t pCallback)
    {
        if (pCallback.m_bActive != 0)
        {
            Debug.Log("Steam Overlay has been activated");
        }
        else
        {
            Debug.Log("Steam Overlay has been closed");
        }
    }

    private void Update()
    {
        //Steamworks.SteamClient.RunCallbacks();
    }

    private void OnApplicationQuit()
    {
        //Steamworks.SteamClient.Shutdown();
    }
}
