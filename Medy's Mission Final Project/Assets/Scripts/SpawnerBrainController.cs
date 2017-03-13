using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBrainController : MonoBehaviour {

	public Transform greenie;
	public Transform yellowie;
	public Transform blackie;
	public Transform reddie;
	public Transform spike1;
	public Transform spike2;
	public Transform spike3;
	public Transform spike4;

	public Transform hole1;
	public Transform hole2;
	public Transform hole3;
	public Transform hole4;

	public float left = GlobalConstants.MIN_X_AXIS+5, 
	right = GlobalConstants.MAX_X_AXIS-5,
	upmin = 7f,
	upmax = 10f;

	int spikeProbabilityMin = 0,
	spikeProbabilityMax = 2;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawnGerms", 0, 1);
		InvokeRepeating ("GenerateSpike1", 0, 5);
		InvokeRepeating ("GenerateSpike2", 0, 10);
		InvokeRepeating ("GenerateSpike3", 0, 15);
		InvokeRepeating ("GenerateSpike4", 0, 20);
	}

	void GenerateGreenie(){
		Instantiate (greenie, new Vector2 (Random.Range (GlobalConstants.MIN_X_AXIS, GlobalConstants.MAX_X_AXIS),
			GlobalConstants.MAX_Y_AXIS), greenie.rotation);
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

	Transform getRandomEnemy (){
		int n = Random.Range (1,4);

		Transform ret = null;

		switch(n){
		case 1: ret = greenie; 		
			break;
		case 2: ret = yellowie;
			break;
		case 3: ret = blackie;
			break;
		case 4: ret = reddie; 		
			break;
		}

		return ret;
	}


	void spawnGerms (){
		Instantiate (getRandomEnemy(), new Vector2 (hole1.transform.position.x
			,hole1.transform.position.y), greenie.rotation);
		Instantiate (getRandomEnemy(), new Vector2 (hole2.transform.position.x
			,hole2.transform.position.y), greenie.rotation);
		Instantiate (getRandomEnemy(), new Vector2 (hole3.transform.position.x
			,hole3.transform.position.y), greenie.rotation);
		Instantiate (getRandomEnemy(), new Vector2 (hole4.transform.position.x
			,hole4.transform.position.y), greenie.rotation);
	}

	

}
