﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMonologue : MonoBehaviour {

    public List<AudioClip> introClips;
    public AudioSource audioSrc;
    public AudioClip timesUp;
    public Animator anim;
    public ParticleSystem particleGas;

	// Use this for initialization
	void Start () {
        StartCoroutine(PlayIntroClips());
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //print(Time.time);
		if(Time.time == 180)
        {
            audioSrc.PlayOneShot(timesUp);
            new WaitForSeconds(timesUp.length);
            EmitGas.emitGas.Invoke();
            anim.SetBool("StartFadeToBlack", true);
            StartRoomEvent.startEscape.Invoke();
            StartCoroutine(StopGas());
            
        }
	}

   public IEnumerator PlayIntroClips()
    {
        foreach(AudioClip introClip in introClips)
        {
            audioSrc.PlayOneShot(introClip);
            yield return new WaitForSeconds(introClip.length + 0.5f);
            
        }
    }

    public IEnumerator StopGas()
    {

        yield return new WaitForSeconds(1.5f);
        particleGas.Stop();
    }
}
