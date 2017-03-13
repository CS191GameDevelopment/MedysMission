using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerHeartController : MonoBehaviour {

	public Transform greenie;
	public Transform yellowie;
	public Transform blackie;
	public Transform reddie;
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
		InvokeRepeating ("GenerateYellowie", 0, 3);
		InvokeRepeating ("GenerateBlackie", 0, 5);
		InvokeRepeating ("GenerateReddie", 0, 6);

		InvokeRepeating ("GenerateSpike1", 0, 20);
		InvokeRepeating ("GenerateSpike2", 0, 25);
		InvokeRepeating ("GenerateSpike3", 0, 30);
		InvokeRepeating ("GenerateSpike4", 0, 35);

	}

	// Update is called once per frame
	void Update () {

	}

	void GenerateGreenie(){
		Instantiate (greenie, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), greenie.rotation);
	}

	void GenerateYellowie(){
		Instantiate (yellowie, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), yellowie.rotation);
	}

	void GenerateBlackie(){
		Instantiate (blackie, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), blackie.rotation);
	}

	void GenerateReddie(){
		Instantiate (reddie, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), reddie.rotation);
	}

	void GenerateSpike1(){
		Instantiate (spike1, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), spike1.rotation);
	}

	void GenerateSpike2(){
		Instantiate (spike2, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), spike2.rotation);
	}

	void GenerateSpike3(){
		Instantiate (spike3, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), spike3.rotation);
	}

	void GenerateSpike4(){
		Instantiate (spike4, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), spike4.rotation);
	}

}
