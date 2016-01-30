using UnityEngine;
using System.Collections;

public class TaxiMover : StevieKiller {

	public float speed = 0.1f;

	// Update is called once per frame
	void FixedUpdate () {
		transform.position += Vector3.forward * speed;
	}
}
