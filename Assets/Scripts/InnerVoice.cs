﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {

	public AudioClip whatHappened; 
	public AudioClip goodLandingArea; 
	private AudioSource audioSource; 

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>(); 
		audioSource.clip = whatHappened; 
		audioSource.Play(); 
	}
	
	void CallHeliStart () {
		audioSource.clip = goodLandingArea; 
		audioSource.Play(); 
		Invoke ("CallHeli", goodLandingArea.length + 1f); 
	}

	void CallHeli () {
		Debug.Log("CallHeli - Invoke OnMakeInitialHeliCall"); 
		SendMessageUpwards ("OnMakeInitialHeliCall"); 
	}
}