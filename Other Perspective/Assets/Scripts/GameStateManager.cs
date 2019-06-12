using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(Chackpoint.OnKeyPuzzleDone == null)
        {
            Chackpoint.OnKeyPuzzleDone = new UnityEvent();
        }
        Chackpoint.OnKeyPuzzleDone.AddListener(KeyPuzzleDone);
	}

    private void KeyPuzzleDone()
    {
        Debug.Log("keyPuzzle Done!!");
    }
	
}
