using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerStomachController : MonoBehaviour {


	public Transform greenie;
	public Transform yellowie;
	public Transform blackie;
	public Transform spike1;
	public Transform spike2;
	public Transform spike3;
	public Transform spike4;

	public float left = GlobalConstants.MIN_X_AXIS+5, 
	right = GlobalConstants.MAX_X_AXIS-5,
	upmin = 7f,
	upmax = 10f;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("GenerateGreenie", 0, 2);
		InvokeRepeating ("GenerateYellowie", 0, 5);
		InvokeRepeating ("GenerateBlackie", 5, 8);
		InvokeRepeating ("GenerateSpike1", 0, 15);
		InvokeRepeating ("GenerateSpike2", 0, 20);
		InvokeRepeating ("GenerateSpike3", 0, 25);
		InvokeRepeating ("GenerateSpike4", 0, 30);
	}

	// Update is called once per frame
	void Update () {

	}

	void GenerateGreenie(){
		Instantiate (greenie, new Vector2 (Random.Range (left, right),
			GlobalConstants.MAX_Y_AXIS), greenie.rotation);
	}


	void GenerateYellowie(){
		Instantiate (yellowie, new Vector2 (Random.Range (left, right),
			GlobalConstants.MAX_Y_AXIS), yellowie.rotation);
	}


	void GenerateBlackie(){
		Instantiate (blackie, new Vector2 (Random.Range (left, right),
			GlobalConstants.MAX_Y_AXIS), blackie.rotation);
	}

	void GenerateSpike1(){
		Instantiate (spike1, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), greenie.rotation);
	}

	void GenerateSpike2(){
		Instantiate (spike2, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), greenie.rotation);
	}

	void GenerateSpike3(){
		Instantiate (spike3, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), greenie.rotation);
	}

	void GenerateSpike4(){
		Instantiate (spike4, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), greenie.rotation);
	}
}
