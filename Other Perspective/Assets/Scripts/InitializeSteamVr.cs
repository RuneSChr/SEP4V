using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class InitializeSteamVr : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        SteamVR.Initialize(true);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
