using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenieController : MonoBehaviour {

	public float moveRate;
	public AudioClip greenieDies;

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
		AudioSource.PlayClipAtPoint (greenieDies, transform.position);
		if (target.gameObject.tag == "Tablet") {
			Destroy (target.gameObject);
			Destroy (gameObject);
			GameObject.Find ("ScoreGenerator").GetComponent<ScoreGeneratorController> ().AddScore (1);
		} else if (target.gameObject.tag == "Medy") {
			Destroy (gameObject);
		}
	}
}
