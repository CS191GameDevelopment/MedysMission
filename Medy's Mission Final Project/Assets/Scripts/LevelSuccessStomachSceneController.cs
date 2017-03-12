using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSuccessStomachSceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("Running Score").GetComponent<Text>().text
		= PlayerPrefs.GetInt ("runningScore").ToString();

		GameObject.Find ("HighScoreValue").GetComponent<Text>().text
		= PlayerPrefs.GetInt ("highScore").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Return)){
			print ("Enter pressed");
			Application.LoadLevel ("Trivia - Heart Scene");
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			print ("Escape pressed");
			Application.Quit ();
		}
	}
}
