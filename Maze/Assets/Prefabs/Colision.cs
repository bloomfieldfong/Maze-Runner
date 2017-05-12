using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CollisionEnter(Collider col){
		if (col.gameObject.name == "Cube") {
			Application.LoadLevel ("menu");
			Destroy (col.gameObject);

		}

	}
}
