using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFootController : MonoBehaviour {

	public Transform greenie;
	public Transform yellowie;
	public Transform blackie;
	public Transform reddie;

	public int left = -8,
	right = 10,
	upmin = 7,
	upmax = 10;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("GenerateGreenie", 0, 2);
		InvokeRepeating ("GenerateYellowie", 0, 2);
		InvokeRepeating ("GenerateBlackie", 0, 2);
		InvokeRepeating ("GenerateReddie", 0, 2);

	}

	// Update is called once per frame
	void Update () {

	}

	void GenerateGreenie(){
		Instantiate (greenie, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), greenie.rotation);
	}

	void GenerateYellowie(){
		Instantiate (yellowie, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), greenie.rotation);
	}

	void GenerateBlackie(){
		Instantiate (blackie, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), greenie.rotation);
	}

	void GenerateReddie(){
		Instantiate (reddie, new Vector2 (Random.Range (left, right), Random.Range (upmin,upmax)), greenie.rotation);
	}

}
