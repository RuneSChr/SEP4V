using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public Transform trans;

	// Use this for initialization
	void Start () {
        Vector3 vec = new Vector3(14, -0.5f, -1.1f);
        trans.position = vec;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
