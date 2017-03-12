using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreGeneratorController : MonoBehaviour {
	public int currScore;
	public int highScore;

	// Use this for initialization
	void Start () {
		//PlayerPrefs.DeleteAll ();
		if(PlayerPrefs.HasKey("highScore")){
			highScore = PlayerPrefs.GetInt("highScore");
		}else{
			PlayerPrefs.SetInt ("highScore",0);
		}

		currScore = PlayerPrefs.GetInt ("runningScore");
	}

	public void AddScore(int num){
		currScore += num ;

		PlayerPrefs.SetInt ("runningScore", currScore);

		if(currScore>highScore){
			highScore = currScore;
			PlayerPrefs.SetInt ("highScore", currScore);
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		GameObject.Find ("ScoreValue").GetComponent<Text>().text = currScore.ToString ();
		GameObject.Find ("HighScoreValue").GetComponent<Text>().text = highScore.ToString ();
	}
}
