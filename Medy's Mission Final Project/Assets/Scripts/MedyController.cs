using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedyController : MonoBehaviour {
	public float moveRate = 0.2f;
	public bool isDead = false;
	public AudioClip tabletSound;
	public Transform fireProjectile;
	public float volume = 0.1f;
	private int hp = 6;

	// Use this for initialization
	void Start () {
		rigid
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
		
		if(transform.position.x > GlobalConstants.MAX_X_AXIS){
			transform.position = new Vector2(GlobalConstants.MAX_X_AXIS, transform.position.y);
		}else if(transform.position.x < GlobalConstants.MIN_X_AXIS){
			transform.position = new Vector2(GlobalConstants.MIN_X_AXIS, transform.position.y);
		}

		if(transform.position.y > GlobalConstants.MAX_Y_AXIS){
			transform.position = new Vector2(transform.position.x, GlobalConstants.MAX_Y_AXIS);
		}else if(transform.position.y < GlobalConstants.MIN_Y_AXIS){
			transform.position = new Vector2(transform.position.x, GlobalConstants.MIN_Y_AXIS);
		}
	}

	public void OnCollisionEnter2D(Collision2D target){
		if(target.gameObject.tag == "Yellowie" || target.gameObject.tag == "Greenie"
			|| target.gameObject.tag == "Blackie" || target.gameObject.tag == "GermAttack"){

			if(target.gameObject.tag == "GermAttack"){
				Destroy (target.gameObject);
			}

			print ("Medy health: "+(hp-1));
			if(--hp==0){
				Destroy (gameObject);
				Destroy (target.gameObject);	
			}

		}
	}
}
