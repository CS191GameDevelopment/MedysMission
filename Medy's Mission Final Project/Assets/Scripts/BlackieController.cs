using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackieController : MonoBehaviour {

	public float moveRate;
	public Transform fireProjectile;
	private int hp = 3;
	public AudioClip blackieHurt;
	public AudioClip blackieDies;
	private Animator blackieAnimator;

	// Use this for initialization
	void Start () {
		moveRate = GlobalConstants.ENEMY_FALL_SPEED;

		//moveRate = 0f;

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

		blackieAnimator = this.gameObject.GetComponent<Animator> ();
		blackieAnimator.SetBool ("isFiring",true);

		StartCoroutine (stopFiringAnim());
	}

	IEnumerator stopFiringAnim(){
		yield return new WaitForSeconds (1.5f);
		Instantiate (fireProjectile, new Vector2(transform.position.x, transform.position.y)
			, fireProjectile.rotation);
		print ("Waited");
		blackieAnimator.SetBool ("isFiring",false);
	}


	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Tablet") {
			Destroy (target.gameObject);

			AudioSource.PlayClipAtPoint (blackieHurt, transform.position);

			--hp;

			print ("Blackie health: " + hp);

			if(hp == 1){
				blackieAnimator.SetBool ("isHurt", true);
			}else if (hp == 0) {
				AudioSource.PlayClipAtPoint (blackieDies, transform.position);
				//Destroy (gameObject);

				if(null==blackieAnimator){
					blackieAnimator = gameObject.GetComponent<Animator> ();
				}
				blackieAnimator.SetBool ("isDead", true);
				Destroy (gameObject.GetComponent<PolygonCollider2D>());
				StartCoroutine (destroyGameObject());

				GameObject.Find ("ScoreGenerator").GetComponent<ScoreGeneratorController> ().AddScore (3);
			}
		} else if (target.gameObject.tag == "Medy") {
			AudioSource.PlayClipAtPoint (blackieDies, transform.position);
			Destroy (gameObject);
		}
	}

	IEnumerator destroyGameObject(){
		yield return new WaitForSeconds (0.5f);
		Destroy (gameObject);
	}
}
