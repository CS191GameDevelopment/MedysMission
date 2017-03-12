using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerminatorController : MonoBehaviour {

	public float moveRate = 0.025f;

	private bool isMovingLeft = true;

	private float adjustmentLimit = 3f;

	private int hp = 20;

	private Animator germHeartanimator;

	private Animator germAnimator;

	// Use this for initialization
	void Start () {
		germHeartanimator = GameObject.Find ("Germinator Heart").GetComponent<Animator> ();
		germAnimator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float x = transform.position.x;
		float y = transform.position.y;

		if (isMovingLeft == true) {
			if ((x - moveRate) >= (GlobalConstants.MIN_X_AXIS+adjustmentLimit)) {
				transform.position = new Vector2 (x - moveRate, y);		
			} else {
				isMovingLeft = false;
			}
		
		}

		if (isMovingLeft == false){
			if ((x + moveRate) <= (GlobalConstants.MAX_X_AXIS-adjustmentLimit)) {
				transform.position = new Vector2 (x + moveRate, y);		
			} else {
				isMovingLeft = true;
			}
		}

	}

	public void OnCollisionEnter2D(Collision2D target){
		if(target.gameObject.tag == "Tablet"){
			Destroy (target.gameObject);

			print ("Germinator HP: "+(hp-1));
			germHeartanimator.SetInteger ("germHeartHp", hp-1);

			if(--hp==0){
				Destroy (GameObject.Find ("Germinator Heart"));
				germAnimator.SetBool ("isDead", true);
				StartCoroutine (endGame());
			}
		}
	}

	IEnumerator endGame(){
		print ("Firing Delay");
		yield return new WaitForSeconds (2.0f);
		Application.LoadLevel ("Congratulations Scene");
	}
}
