﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayTimeController : MonoBehaviour {

	public int timeLeft;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("count", 0, 1);
	}


	public void count (){
		GameObject.Find ("TimeLeftValue").GetComponent<Text> ().text = timeLeft.ToString ();
		if (timeLeft > 0) {
			timeLeft--;
		} else {
			Application.LoadLevel ("Game Over Scene");
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
