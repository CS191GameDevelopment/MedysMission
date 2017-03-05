using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedyController : MonoBehaviour {
	public float moveRate = 0.2f;
	public bool isDead = false;
	public AudioClip tabletSound;
	public Transform fireProjectile;
	public float volume = 0.1f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		if(false == isDead){
			shoot ();
			movePlayer ();
		}
	}

	public void shoot(){
		if(Input.GetKeyDown("space")){
			Instantiate (fireProjectile, new Vector2(transform.position.x, transform.position.y)
				, fireProjectile.rotation);
			AudioSource.PlayClipAtPoint (tabletSound, transform.position);
		}
	}

	public void movePlayer(){
		float moveX = Input.GetAxis("Horizontal");
		float moveY = Input.GetAxis("Vertical");

		//Move the player
		transform.position = new Vector2(transform.position.x + moveX * moveRate
			, transform.position.y + moveY * moveRate);
	}
}
