using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReddieController : MonoBehaviour {


	private float moveRate;
	public AudioClip reddieHurt;
	public AudioClip reddieDies;
	private int hp = 3;

	// Use this for initialization
	void Start () {
		moveRate = GlobalConstants.ENEMY_FALL_SPEED;
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

			print ("Reddie health: " + (hp - 1));
			if (--hp == 0) {
				AudioSource.PlayClipAtPoint (reddieDies, transform.position);
				Destroy (gameObject);
				GameObject.Find ("ScoreGenerator").GetComponent<ScoreGeneratorController> ().AddScore (5);
			}
		} else if (target.gameObject.tag == "Medy") {
			AudioSource.PlayClipAtPoint (reddieDies, transform.position);
			Destroy (gameObject);
		}
	}
}
