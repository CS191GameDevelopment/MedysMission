using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjetileController : MonoBehaviour {

	public float moveRate = .1f;

	void Start(){
		
	}

	void FixedUpdate(){
		transform.position = new Vector2 (transform.position.x, transform.position.y + moveRate);
	}

	void OnCollisionEnter2D(Collision2D target){
		if(target.gameObject.tag == "TopBorder"){
			Destroy (gameObject);
		}else if(target.gameObject.tag == "Enemy"){
			Destroy (gameObject);
			Destroy (target.gameObject);
		}
	}
}
