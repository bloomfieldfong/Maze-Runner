using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
		

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Player 1 1 (Clone)") {
			Application.LoadLevel ("menu");
			Destroy (col.gameObject);

		}
		
	}

}
