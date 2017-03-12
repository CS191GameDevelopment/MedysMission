using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratulationsSceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Return)){
			print ("Enter pressed");
			Application.LoadLevel ("Home Start Screen");
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			print ("Escape pressed");
			Application.Quit ();
		}
	}
}
