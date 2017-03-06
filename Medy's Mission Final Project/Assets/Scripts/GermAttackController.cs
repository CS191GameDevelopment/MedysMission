using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GermAttackController : MonoBehaviour {

	public float moveRate = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		//get the current position of Medy

		//get the current position of GermAttack

		//solve for slope
		//Note: y is always going down and x can move left and right

		transform.position = new Vector2 (transform.position.x, transform.position.y - moveRate);

		if (transform.position.y < -10) {
			Destroy (gameObject);
		}
	}
}
