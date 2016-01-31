using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public float leftContraint;
	public float rightConstraint;

	Transform stevie;

	void Start() {
		stevie = FindObjectOfType<Stevie> ().transform;

		InvokeRepeating ("UpdateBoxPos", 5.0f, 5.0f);
	}

	// Update is called once per frame
	void UpdateBoxPos () {
		if (this.stevie.position.z - this.transform.position.z > 10f) {
			Vector3 newPos = transform.position;
			newPos.z = Mathf.Round (this.stevie.position.z + 20f);
			newPos.x = Mathf.Round (Random.Range (leftContraint, rightConstraint));
			this.transform.position = newPos;
			this.transform.eulerAngles = Vector3.up * (Random.Range (0, 4) * 90);
		}
	}

	void OnCollisionEnter(Collision c) {
		Stevie stevie = c.gameObject.GetComponent<Stevie> ();
		if (stevie) {
			stevie.Die ();
		}
	}
}
