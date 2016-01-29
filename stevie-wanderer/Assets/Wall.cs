using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	Transform stevie;

	void Start() {
		stevie = FindObjectOfType<Stevie> ().transform;
	}

	// Update is called once per frame
	void Update () {
		if (this.stevie.position.z - this.transform.position.z > 5) {
			Vector3 newPos = this.transform.position;
			newPos.z = this.stevie.position.z + 10;
			this.transform.position = newPos;
		}
	}


}
