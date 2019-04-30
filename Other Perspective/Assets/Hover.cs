using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class Hover : MonoBehaviour {

    private InteractionBehaviour action;

    public GameObject canvasNote;
	// Use this for initialization
	void Start () {
        action = GetComponent<InteractionBehaviour>();
        action.OnHoverBegin += Test2;
        action.OnHoverEnd += Test;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Test()
    {
        canvasNote.SetActive(false);
    }

    void Test2()
    {
        canvasNote.SetActive(true);
    }
}
