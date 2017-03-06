using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackieController : MonoBehaviour {

	public float moveRate = 0.007f;
	public Transform fireProjectile;
	private int hp = 3;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("shoot", 0, 5);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector2 (transform.position.x, transform.position.y - moveRate);

		if (transform.position.y < -10) {
			Destroy (gameObject);
		}
	}

	public void shoot(){
		print ("Blackie shooting");
		print (null==fireProjectile);
		Instantiate (fireProjectile, new Vector2(transform.position.x, transform.position.y)
			, fireProjectile.rotation);
	}

	void OnCollisionEnter2D(Collision2D target){
		if(target.gameObject.tag == "Tablet"){
			Destroy (target.gameObject);
			print ("Blackie health: " + (hp-1));
			if(--hp == 0){
				Destroy (gameObject);
			}
		}
	}
}
