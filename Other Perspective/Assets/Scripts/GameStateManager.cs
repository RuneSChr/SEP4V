using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour {

    public GameObject glasses, bow;
	// Use this for initialization
	void Start () {
		if(Chackpoint.OnKeyPuzzleDone == null)
        {
            Chackpoint.OnKeyPuzzleDone = new UnityEvent();
        }
        if (DoneTest.onMixingDone == null) DoneTest.onMixingDone = new UnityEvent();
        DoneTest.onMixingDone.AddListener(FluidPuzzleDone);
        Chackpoint.OnKeyPuzzleDone.AddListener(KeyPuzzleDone);
	}

    private void KeyPuzzleDone()
    {
        Debug.Log("keyPuzzle Done!!");
    }

    private void FluidPuzzleDone()
    {
        Debug.Log("fluidPuzzle Done");
        glasses.SetActive(true);
        bow.SetActive(true);
    }

    private void OnDestroy()
    {
        Chackpoint.OnKeyPuzzleDone.RemoveListener(KeyPuzzleDone);
        DoneTest.onMixingDone.RemoveListener(FluidPuzzleDone);
    }

}
