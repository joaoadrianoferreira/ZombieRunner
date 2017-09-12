using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

	public float timeSinceLastTrigger = 0; 
	private AudioSource audio; 
	private bool foundClearArea = false; 

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>(); 
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastTrigger += Time.deltaTime; 

		if (timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f && !foundClearArea) {
			Debug.Log("Invoke OnFindClearArea");
			SendMessageUpwards ("OnFindClearArea"); 
			foundClearArea = true; 
		}
	}

	void OnTriggerStay (Collider collider) {
		if (collider.tag != "Player") {
			timeSinceLastTrigger = 0; 
		}
	}
}
