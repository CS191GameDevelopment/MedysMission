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

	private float left = GlobalConstants.MIN_X_AXIS,
	right = GlobalConstants.MAX_X_AXIS,
	upmin = GlobalConstants.MIN_Y_AXIS,
	upmax = GlobalConstants.MAX_Y_AXIS;

	int spikeProbabilityMin = 0,
	spikeProbabilityMax = 2;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawnGerms", 0, 10);

	}
	
	// Update is called once per frame
	void Update () {
		
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
