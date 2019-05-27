using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyholeTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger enter");

        //related function for starting next puzzle
    }
}
