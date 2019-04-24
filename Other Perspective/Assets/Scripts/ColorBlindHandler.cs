using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;

public class ColorBlindHandler : MonoBehaviour {

    [SerializeField]
    private Colorblind ColorBlindScript;

    void Start()
    {
        //GetComponent<IColorBlind>().OnShadesChanged += HandleSpectrumChange;
        GameObject cam = GameObject.FindGameObjectWithTag("MainCamera");
        ColorBlindScript = cam.GetComponent<Colorblind>();
    }
    void Awake()
    {
        
    }

    public void HandleSpectrumChange(int shadeIndex)
    {
        ColorBlindScript.Type = shadeIndex;
    }

  
}
