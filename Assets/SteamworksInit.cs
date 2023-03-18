using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class SteamworksInit : MonoBehaviour
{
	// Start is called before the first frame update

	void Start()
	{
		if (SteamManager.Initialized)
		{
			string name = SteamFriends.GetPersonaName();
			Debug.Log(name);
		}
	}
}
