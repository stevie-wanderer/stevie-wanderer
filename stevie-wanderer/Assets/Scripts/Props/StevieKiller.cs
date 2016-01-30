using UnityEngine;
using System.Collections;

public class StevieKiller : MonoBehaviour {

	Transform stevie;

	public void Start() {
		stevie = FindObjectOfType<Stevie> ().transform;
	}

	public Transform GetStevie() {
		return stevie;
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.GetComponent<Stevie> ()) {
			Debug.Log ("Game Over");
			Debug.Log ("Your score: " + Mathf.Round(stevie.position.z));
			Time.timeScale = 0;
			Debug.Log ("Press 'r' to restart");
		}
	}
}
