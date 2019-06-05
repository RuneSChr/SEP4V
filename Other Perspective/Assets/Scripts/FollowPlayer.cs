using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    private Transform playerTransform;
    private Vector3 offset;
    [SerializeField]
    private float x, y, z;
	// Use this for initialization
	void Awake () {
        x = 0;
        y = 0;
        z = 0;
        playerTransform = GameObject.Find("Player/NoSteamVRFallbackObjects").transform; /*GameObject.Find("Player /SteamVRObjects/VRCamera").transform;*/
        offset = new Vector3(x, y, z);
        
	}
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.position = playerTransform.position + offset;
        print(playerTransform.position);
        print(gameObject.transform.position);
	}
}
