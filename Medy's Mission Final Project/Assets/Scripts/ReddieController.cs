using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReddieController : MonoBehaviour {


	public float moveRate = 0.1f;
	public AudioClip reddieHurt;
	public AudioClip reddieDies;
	private int hp = 3;

	// Use this for initialization
	void Start () {
		moveRate = GlobalConstants.ENEMY_FALL_SPEED;
		InvokeRepeating ("doubleteam", 0, 5);
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


	void doubleteam(){
	//power of reddie to summon another reddie
	}
}
