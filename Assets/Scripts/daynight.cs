using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynight : MonoBehaviour {

	public float timeScale; 
	private Quaternion starRotation; 

	// Use this for initialization
	void Start () {
		starRotation = transform.rotation; 
	}
	
	// Update is called once per frame
	void Update () {
		float angleThisFrame = Time.deltaTime / 360 * timeScale; 
		transform.RotateAround(transform.position, Vector3.forward, angleThisFrame); 
	}
}
