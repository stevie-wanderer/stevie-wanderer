using UnityEngine;
using System.Collections;

public class StevieKiller : MonoBehaviour {

	Transform stevie;
	public int damage = 1;
	public bool killsDog = false;

	public void Start() {
		stevie = FindObjectOfType<Stevie> ().transform;
	}

	public Transform GetStevie() {
		return stevie;
	}

	void OnCollisionEnter(Collision c) {
		Stevie hitStevie = c.gameObject.GetComponent<Stevie> ();
		if (hitStevie != null) {
			hitStevie.LoseHealth (this.damage, c.contacts[0].point);
		}

		if (killsDog) {
			Dog hitDoge = c.gameObject.GetComponent<Dog> ();
			if (hitDoge) {
				hitDoge.Die (c.contacts [0].point, this.damage * 5.0f);
			}
		}
	}
}
