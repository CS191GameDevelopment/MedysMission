using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour {

	public float moveRate = GlobalConstants.ENEMY_FALL_SPEED;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {		
		transform.position = new Vector2 (transform.position.x, transform.position.y - moveRate);


		if (transform.position.y < -10) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Tablet") {
			Destroy (target.gameObject);
		}
	}
}
