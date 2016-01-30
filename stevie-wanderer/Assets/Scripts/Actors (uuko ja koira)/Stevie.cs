using UnityEngine;
using System.Collections;

public class Stevie : MonoBehaviour {

	void Start() {
		this.GetComponent<Rigidbody> ().velocity = Vector3.forward;
	}

	// Update is called once per frame
	void FixedUpdate () {
		this.GetComponent<Rigidbody> ().AddForce (Vector3.forward * 10);
	}
}
