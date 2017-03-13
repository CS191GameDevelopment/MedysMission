using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReddieController : MonoBehaviour {

	private float moveRate;
	public AudioClip reddieHurt;
	public AudioClip reddieDies;
	private int hp = 3;
	private Animator reddieAnimator;

	// Use this for initialization
	void Start () {
		moveRate = GlobalConstants.ENEMY_FALL_SPEED;
		reddieAnimator = gameObject.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (transform.position.x, transform.position.y - moveRate);

		if (transform.position.y < GlobalConstants.MIN_Y_AXIS-3) {
			Destroy (gameObject);
		}

	}


	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Tablet") {
			Destroy (target.gameObject);

			AudioSource.PlayClipAtPoint (reddieHurt, transform.position);

			--hp;
			print ("Reddie health: " + hp);

			if(hp==1){
				reddieAnimator.SetBool("isHurt", true);
			}else if (hp == 0) {
				AudioSource.PlayClipAtPoint (reddieDies, transform.position);
				StartCoroutine (destroyGameObject());
				Destroy (gameObject.GetComponent<PolygonCollider2D>());
				GameObject.Find ("ScoreGenerator").GetComponent<ScoreGeneratorController> ().AddScore (5);
			}
		} else if (target.gameObject.tag == "Medy") {
			AudioSource.PlayClipAtPoint (reddieDies, transform.position);
			Destroy (gameObject);
		}
	}

	IEnumerator destroyGameObject(){
		yield return new WaitForSeconds (0.5f);
		Destroy (gameObject);
	}
}