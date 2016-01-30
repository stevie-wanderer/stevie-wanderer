using UnityEngine;
using System.Collections;

public class TaxiMover : StevieKiller {

	public float speed = 0.1f;
	public float spawnDistance = 50.0f;

	void Start() {
		base.Start ();
		InvokeRepeating ("SpawnNewTaxi", 10.0f, 10.0f);
	}

	// Update is called once per frame
	void FixedUpdate () {
		transform.position += Vector3.forward * speed;
	}

	void SpawnNewTaxi() {
		this.speed += this.speed * 0.5f;
		if (this.transform.position.z > GetStevie ().position.z + spawnDistance) {
			Vector3 newPos = this.transform.position;
			newPos.z = GetStevie ().position.z - spawnDistance;
			this.transform.position = newPos;
		}
	}

}
