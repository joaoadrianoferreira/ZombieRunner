using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopte : MonoBehaviour {

	public bool called = false; 
	private Rigidbody rigidBody; 

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();  
	}

	public void OnDispatchHelicopter () {
		Debug.Log("OnDispatchHelicopter"); 
		rigidBody.velocity = new Vector3 (0, 0, 50f); 
		called = true; 
	}
}
