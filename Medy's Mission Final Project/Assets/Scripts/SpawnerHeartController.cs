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

	public int left = -8,
	right = 10,
	upmin = 7,
	upmax = 10;

	int spikeProbabilityMin = 0,
	spikeProbabilityMax = 2;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("GenerateGreenie", 0, 2);
		InvokeRepeating ("GenerateYellowie", 0, 2);
		InvokeRepeating ("GenerateBlackie", 0, 2);
		InvokeRepeating ("GenerateReddie", 0, 2);
		InvokeRepeating ("GenerateSpike1", spikeProbabilityMin, spikeProbabilityMax);
		InvokeRepeating ("GenerateSpike2", spikeProbabilityMin, spikeProbabilityMax);
		InvokeRepeating ("GenerateSpike3", spikeProbabilityMin, spikeProbabilityMax);
		InvokeRepeating ("GenerateSpike4", spikeProbabilityMin, spikeProbabilityMax);

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
