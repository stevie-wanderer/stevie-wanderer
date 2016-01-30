using UnityEngine;
using System.Collections;

public class Stevie : MonoBehaviour {

	public Animator stevieAnimator;

	void Start() {
		this.GetComponent<Rigidbody> ().velocity = Vector3.forward;
	}

	// Update is called once per frame
	void FixedUpdate () {
		this.GetComponent<Rigidbody> ().AddForce (Vector3.forward * 10);
	}

	void Update() {
		// Look at the direction where you're going
		transform.LookAt (this.transform.position + this.GetComponent<Rigidbody> ().velocity);
		stevieAnimator.speed = this.GetComponent<Rigidbody> ().velocity.sqrMagnitude / 1.4f;
	}
}
