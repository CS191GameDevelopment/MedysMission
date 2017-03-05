using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour {

	public float moveRate;
	// Use this for initialization
	void Start () {
		moveRate = Random.Range (0.03f, 0.08f);
	}
	
	// Update is called once per frame
	void Update () {		
		transform.position = new Vector2 (transform.position.x, transform.position.y - moveRate);


		if (transform.position.y < -10) {
			Destroy (gameObject);
		}
	}
}
