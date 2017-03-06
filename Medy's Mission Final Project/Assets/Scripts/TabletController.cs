using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletController : MonoBehaviour {

	public float moveRate = .1f;


	void Start(){
	}

	void FixedUpdate(){
		transform.position = new Vector2 (transform.position.x, transform.position.y + moveRate);


		if (transform.position.y > 10) {
			Destroy (gameObject);
		}

	}


}
