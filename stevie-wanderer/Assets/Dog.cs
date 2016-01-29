using UnityEngine;
using System.Collections;

public class Dog : MonoBehaviour {

	public Vector3 velocity = Vector3.zero;
	private const float MAX_HIHNA_LENGTH = 5;
	Transform stevie;

	// Use this for initialization
	void Start () {
		stevie = FindObjectOfType<Stevie> ().transform;
	}

	void FixedUpdate() {

		this.velocity = Vector3.zero;

		if (Input.GetKey (KeyCode.UpArrow)) {
			this.velocity += Vector3.forward;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			this.velocity -= Vector3.forward;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.velocity += Vector3.left;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.velocity += Vector3.right;
		}

		float multiplier = 4.0f;
		float zDiff = stevie.position.z - transform.position.z;
		if (zDiff > MAX_HIHNA_LENGTH && velocity.z < 0.0f) {
			multiplier = 0.0f;
		} else if (Vector3.Distance (transform.position, stevie.position) > MAX_HIHNA_LENGTH && !(velocity.z < 0.0f && zDiff > -0.1f)) {
			multiplier = 1.0f;
		}

		this.GetComponent<Rigidbody> ().velocity = this.velocity * multiplier;

		this.transform.LookAt (this.transform.position + this.velocity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
