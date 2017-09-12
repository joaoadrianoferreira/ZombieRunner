using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

	public AudioClip initialHeliCall; 
	public AudioClip initialCallReply; 

	private AudioSource audioSource; 

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>(); 
	}
	
	void OnMakeInitialHeliCall () {
		audioSource.clip = initialHeliCall; 
		audioSource.Play(); 
		Debug.Log("OnMakeInitialHeliCall - Invoke InitialReply");
		Invoke ("InitialReply", initialHeliCall.length + 1f); 
	}

	void InitialReply () {
		audioSource.clip = initialCallReply; 
		audioSource.Play(); 
		Debug.Log("InitialReply - Invoke OnDispatchHelicopter");
		BroadcastMessage ("OnDispatchHelicopter"); 
	}
}
