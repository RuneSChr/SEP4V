
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;


public class OpenTips : MonoBehaviour
{
    public GameObject tip;
    private InteractionBehaviour behave;

	// Use this for initialization
	void Start () {
        behave = GetComponent<InteractionBehaviour>();
        behave.OnGraspBegin += Test;
    }

    void Test()
    {
        tip.SetActive(true);
    }

    private void OnDestroy()
    {
        behave.OnGraspBegin -= Test;
    }
}


