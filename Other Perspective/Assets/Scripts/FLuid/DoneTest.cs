using System;
using System.Collections;
using System.Collections.Generic;
using Obi;
using TMPro;
using UnityEngine;

public class DoneTest : MonoBehaviour
{
    public string msg;
    private ObiEmitter emitter;
    private Color targetColor;
    private Color color = Color.black;
    private bool done = false;

    private bool stop = false;
	// Use this for initialization
	void Start ()
    {
        emitter = GetComponent<ObiEmitter>();
        targetColor = new Color(1.000f, 0.000f, 0.830f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (stop)
        {
            return;
        }
        if (done)
        {
            Debug.Log(msg + ": " + "Done!!");
            stop = true;
            return;
        }

        if (Math.Abs(color.r - 1f) < 0.005 && Math.Abs(color.g - 0f) < 0.005 && Math.Abs(color.b - 0.830f) < 0.005)
        {
            done = true;
        }
        else if (color != emitter.colors[150])
        {
            color = emitter.colors[150];

        }
    }
}
