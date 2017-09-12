using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

	private Camera eyes;
	private float defaultView;  

	// Use this for initialization
	void Start () {
		eyes = GetComponent<Camera>(); 
		defaultView = eyes.fieldOfView;
  
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Zoom")) {
			eyes.fieldOfView = defaultView / 1.5f; 
		} else {
			eyes.fieldOfView = defaultView; 
		}
	}



}
