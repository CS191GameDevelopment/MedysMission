using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D target){
		if(target.gameObject.tag == "BottomBorder"){
			Destroy (gameObject);
		}else if(target.gameObject.tag == "Player"){
			Destroy (target.gameObject);
		}
	}
}
