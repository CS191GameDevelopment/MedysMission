using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReddieCloneController : MonoBehaviour {

	public Transform reddieClone;

	// Use this for initialization
	void Start () {
		kagebunshin ();
		StartCoroutine (kagebunshin());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator kagebunshin(){
		print ("coroutine started");

		yield return new WaitForSeconds (1.5f);

		print ("coroutine ended");

		Instantiate (reddieClone, new Vector2(transform.position.x - 3
			, transform.position.y)
			, reddieClone.rotation);
		
		/*
			Instantiate (reddieDraft, new Vector2(transform.position.x - 3
			, transform.position.y)
			, reddieDraft.rotation);
		*/
	}

}
