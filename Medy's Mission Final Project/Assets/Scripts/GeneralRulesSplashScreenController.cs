using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralRulesSplashScreenController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyUp(KeyCode.Return)){
			print ("Enter pressed Go to next screen pa");
			//Application.LoadLevel ("2 - Medy Introduction");
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			print ("Escape pressed");
			Application.Quit ();
		}
	}
}
