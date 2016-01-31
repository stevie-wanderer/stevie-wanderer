using UnityEngine;
using System.Collections;

public class TaxiWheelRotator : MonoBehaviour {

	public Vector3 rotateAround = Vector3.left;

	// Update is called once per frame
	void Update () {
		transform.Rotate(rotateAround);
	}
}
