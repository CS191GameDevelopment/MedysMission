using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSuccessFootSceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("Running Score").GetComponent<Text>().text
			= PlayerPrefs.GetInt ("runningScore").ToString();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyUp(KeyCode.Return)){
			print ("Enter pressed");
			Application.LoadLevel ("Trivia - Limbs Scene");
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			print ("Escape pressed");
			Application.Quit ();
		}
		
	}
}
