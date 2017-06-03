using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisao : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void onCollisionEnter(Collision colider) {

		if (colider.gameObject.tag == "morte") {
			Destroy (gameObject);
		
		
		}

	}
}
