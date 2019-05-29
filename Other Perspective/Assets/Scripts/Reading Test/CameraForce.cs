using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraForce : MonoBehaviour
{
    public static bool forceBack;
    private Rigidbody camera;

	// Use this for initialization
	void Start ()
    {
        camera = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (forceBack)
        {
            camera.AddForce(-transform.forward*5000,ForceMode.Impulse);
            forceBack = false;
        }
	}
}
