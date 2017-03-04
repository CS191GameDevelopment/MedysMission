using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeddyAndTabletPreparingForMissionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyUp(KeyCode.Return)){
			print ("Enter pressed");
			Application.LoadLevel ("5 - General Rules Splash Screen");
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			print ("Escape pressed");
			Application.Quit ();
		}
	}
}
