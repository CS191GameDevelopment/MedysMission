using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour {

	public Transform enemyPrefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("GenerateEnemy", 0,2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void GenerateEnemy(){
		Instantiate (enemyPrefab, new Vector2(Random.Range(-16,14),Random.Range(13,14)), enemyPrefab.rotation);
	}
}
