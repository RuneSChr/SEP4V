
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;


public class OpenTips : MonoBehaviour
{
    private Material _material;

    private InteractionBehaviour _intObj;

    public GameObject tip;

    // Use this for initialization
    void Start () {
        _intObj = GetComponent<InteractionBehaviour>();

        _intObj.OnHoverBegin += Test;

        Renderer renderer = GetComponent<Renderer>();
        if (renderer == null)
        {
            renderer = GetComponentInChildren<Renderer>();
        }
        if (renderer != null)
        {
            _material = renderer.material;
        }
    }

    private void Update()
    {
        if (_intObj is InteractionButton && (_intObj as InteractionButton).isPressed)
        {
            tip.SetActive(false);
        }
    }

    void Test()
    {
        tip.SetActive(false);
    }

 /*   private void OnDestroy()
    {
        behave.OnGraspBegin -= Test;
    }*/
}


