 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Transform playerSpawnPoints; 
	public bool reSpawn = false; 
	public bool lastToggle = false; 
	private Transform[] spwnPoints; 
	public Helicopte helicopter; 
	public GameObject landingArea; 

	// Use this for initialization
	void Start () {
		spwnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>(); 
		helicopter = GameObject.FindObjectOfType<Helicopte>(); 
	}
	
	// Update is called once per frame
	void Update () {
		if (lastToggle != reSpawn) {
			ReSpawn(); 
			reSpawn = false; 
		} else {
			lastToggle = reSpawn;  
		}
		
	}

	public void ReSpawn () {
		int i = Random.Range(1, spwnPoints.Length); 
		gameObject.transform.position = spwnPoints[i].transform.position; 
	}

	void OnFindClearArea () {
		Debug.Log("OnFindClearArea - Invoke DropFlare"); 
		Invoke ("DropFlare", 3f); 
	}

	void DropFlare () {
		Instantiate (landingArea, transform.position, transform.rotation);  
		BroadcastMessage ("CallHeliStart"); 
	}
}
	