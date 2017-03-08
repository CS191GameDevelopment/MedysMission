using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowieController : MonoBehaviour {

	public float moveRate;
	private int hp =2;
	public AudioClip yellowieHurt;
	public AudioClip yellowieDies;

	// Use this for initialization
	void Start () {
		moveRate = GlobalConstants.ENEMY_FALL_SPEED;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (transform.position.x, transform.position.y - moveRate);

		if (transform.position.y < -10) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Tablet") {
			Destroy (target.gameObject);

			AudioSource.PlayClipAtPoint (yellowieHurt, transform.position);

			print ("Yellowie health: " + (hp - 1));
			if (--hp == 0) {
				AudioSource.PlayClipAtPoint (yellowieDies, transform.position);
				Destroy (gameObject);
				GameObject.Find ("ScoreGenerator").GetComponent<ScoreGeneratorController> ().AddScore (2);
			}
		} else if (target.gameObject.tag == "Medy") {
			AudioSource.PlayClipAtPoint (yellowieDies, transform.position);
			Destroy (gameObject);
		}
	}
}
