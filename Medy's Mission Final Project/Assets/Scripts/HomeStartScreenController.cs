using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeStartScreenController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int highScore = 0;

		PlayerPrefs.SetInt ("runningScore",0);

		if(PlayerPrefs.HasKey("highScore")){
			highScore = PlayerPrefs.GetInt("highScore");
		}else{
			PlayerPrefs.SetInt ("highScore",0);
		}

		GameObject.Find ("HighScoreValue").GetComponent<Text>().text = highScore.ToString ();
	}
	
	// Update is called once per frame
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyUp(KeyCode.Return)){
			print ("Enter pressed");
			Application.LoadLevel ("General Rules Splash Screen");
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			print ("Escape pressed");
			Application.Quit ();
		}
	}
}
