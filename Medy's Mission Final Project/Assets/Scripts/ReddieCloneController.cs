using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReddieCloneController : MonoBehaviour {

	public Transform reddieClone;

	private Animator reddieAnimator;

	// Use this for initialization
	void Start () {
		kagebunshin ();
		StartCoroutine (kagebunshin());
		reddieAnimator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator kagebunshin(){
		print ("coroutine started");

		yield return new WaitForSeconds (3f);

		print ("coroutine ended");

		reddieAnimator.SetBool ("isTransforming", true);

		StartCoroutine (finishTransform());
	}

	IEnumerator finishTransform(){

		yield return new WaitForSeconds (0.5f);

		Destroy (gameObject);

		int x = 1;

		if(transform.position.x + x > GlobalConstants.MAX_X_AXIS){
			x = -1;
		}

		Instantiate (reddieClone, new Vector2(transform.position.x
			, transform.position.y)
			, reddieClone.rotation);

		Instantiate (reddieClone, new Vector2(transform.position.x + x
			, transform.position.y)
			, reddieClone.rotation);
	}

}
