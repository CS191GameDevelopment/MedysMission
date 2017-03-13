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

	private Animator heartAnimator;
	private Animator medyAnimator;

	public AudioClip medyHurt;
	private bool firingAllowed = true;

	// Use this for initialization
	void Start () {
		heartAnimator = GameObject.Find ("Heart").GetComponent<Animator> ();
		medyAnimator = GameObject.Find ("Medy").GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if(false == isDead){
			shoot ();
			movePlayer ();
		}
	}

	public void shoot(){
		if(Input.GetKeyDown("space") && firingAllowed==true){
			Instantiate (fireProjectile, new Vector2(transform.position.x, transform.position.y)
				, fireProjectile.rotation);
			AudioSource.PlayClipAtPoint (tabletSound, transform.position);
			firingAllowed = false;
			StartCoroutine (delayFiring());
		}
	}

	IEnumerator delayFiring(){
		print ("Firing Delay");
		yield return new WaitForSeconds (0.2f);
		firingAllowed = true;
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
			|| target.gameObject.tag == "Blackie" || target.gameObject.tag == "GermAttack"
			|| target.gameObject.tag == "Reddie" || target.gameObject.tag == "Spike"){

			AudioSource.PlayClipAtPoint (medyHurt, transform.position);

			medyAnimator.SetBool ("isInPain", true);
			StartCoroutine (stopPain ());

			Destroy (target.gameObject);

			hp--;

			heartAnimator.SetInteger ("currentHP", hp);

			print ("Medy health: "+(hp));

			if(hp==1){
				print ("MEDY IS HURT");
				medyAnimator.SetBool ("isHurt", true);
			}else if(hp==0){
				Destroy (gameObject);
				Destroy (target.gameObject);
				Application.LoadLevel ("Game Over Scene");
			}

		}
	}

	IEnumerator stopPain(){
		yield return new WaitForSecondsRealtime(0.5f);
		medyAnimator.SetBool ("isInPain", false);
	}
}

