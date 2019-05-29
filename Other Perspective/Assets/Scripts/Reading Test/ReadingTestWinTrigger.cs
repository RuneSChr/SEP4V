using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadingTestWinTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        //go to next puzzle
        Debug.Log("Win trigger enter!");
    }
}
