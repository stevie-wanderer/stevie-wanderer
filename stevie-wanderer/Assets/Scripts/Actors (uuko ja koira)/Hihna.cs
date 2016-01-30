using UnityEngine;
using System.Collections;

public class Hihna : MonoBehaviour {

	private Vector3 normalHihnaScale;

	void Start() {
		normalHihnaScale = transform.localScale;
	}

	// Update is called once per frame
	void Update () {
		Transform koira = FindObjectOfType<Dog> ().transform;
		transform.LookAt (koira);
		Vector3 hihnanPituus = transform.localScale;
		hihnanPituus.z = Vector3.Distance (koira.position, transform.position) * normalHihnaScale.z;
		transform.localScale = hihnanPituus;
	}
}
