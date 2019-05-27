
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaking : MonoBehaviour {

    public Transform hand;

    public float shakeAmount = 0.7f;

    Vector3 originalPos;

    public Rigidbody rb;

    public static bool forefingerTouch;
    public static bool thumbTouch;

    void Awake()
    {
        if (hand == null)
        {
            hand = GetComponent(typeof(Transform)) as Transform;
        }
    }

    // Use this for initialization
    void Start ()
    {
        forefingerTouch = false;
        thumbTouch = false;
    }
	
	// Update is called once per frame
	void Update () {
        hand.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
    }

    void OnEnable()
    {
        originalPos = hand.localPosition;

    }

}

