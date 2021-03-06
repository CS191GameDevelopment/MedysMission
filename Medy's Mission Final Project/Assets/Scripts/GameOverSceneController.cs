﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverSceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int highScore = 0;

		GameObject.Find ("Running Score").GetComponent<Text>().text
		= PlayerPrefs.GetInt ("runningScore").ToString();

		if(PlayerPrefs.HasKey("highScore")){
			highScore = PlayerPrefs.GetInt("highScore");
		}else{
			PlayerPrefs.SetInt ("highScore",0);
		}

		GameObject.Find ("HighScoreValue").GetComponent<Text>().text = highScore.ToString ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyUp(KeyCode.Return)){
			print ("Enter pressed");
			Application.LoadLevel ("Home Start Screen");
		}
		if(Input.GetKeyUp(KeyCode.F)){
			print ("F presses");
			Application.LoadLevel ("Gameplay - Brain Scene");
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			print ("Escape pressed");
			Application.Quit ();
		}
	}
}
