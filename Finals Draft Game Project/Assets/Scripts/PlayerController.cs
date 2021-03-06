﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveRate = 0.2f;
	public bool isDead = false;

	public Transform fireProjectile;

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
			Instantiate (fireProjectile, new Vector2(transform.position.x, transform.position.y + 4)
				, fireProjectile.rotation);
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
