﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;

public class ColorBlindHandler : MonoBehaviour {

    [SerializeField]
    private Colorblind ColorBlindScript;
    //[SerializeField]
    

    void Awake()
    {      

    }

    void Start()
    {
        //GetComponent<IColorBlind>().OnShadesChanged += HandleSpectrumChange;
        //GameObject cam = GameObject.FindGameObjectWithTag("MainCamera");

    }

    private void FixedUpdate()
    {
       
        //ColorBlindScript = GetComponent<Colorblind>();
        //print(ColorBlindScript);
        
    }
   

    public void ChangeSpectrum(int shadeIndex)
    {

        ColorBlindScript.Type = shadeIndex;
        
    }

   


}
