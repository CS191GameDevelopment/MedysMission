using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowieController : MonoBehaviour {

	public float moveRate = 0.1f;

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
}
