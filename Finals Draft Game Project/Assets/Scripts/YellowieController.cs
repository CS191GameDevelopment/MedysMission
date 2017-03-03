using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowieController : MonoBehaviour {

	private int lifePoints = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnCollisionEnter2D(Collision2D target){
		if(target.gameObject.tag == "FireProjectile"){
			Destroy (target.gameObject);
			if(lifePoints !=0 ){
				lifePoints--;
			}else if (lifePoints == 0){
				Destroy (gameObject);	
			}

		}
	}
}
