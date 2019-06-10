using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class LeapButton : MonoBehaviour {

    private InteractionBehaviour interaction;
    public OpenDoor doorOpen;
    public string number;

	// Use this for initialization
	void Start () {
        interaction = GetComponent<InteractionBehaviour>();
        interaction.OnContactBegin += ButtonFunction;
	}

    void ButtonFunction()
    {
        doorOpen.ButtonInput(number);
    }


}
