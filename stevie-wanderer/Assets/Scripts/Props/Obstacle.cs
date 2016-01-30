using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Obstacle : MonoBehaviour {

	Transform stevie;

	void Start() {
		stevie = FindObjectOfType<Stevie> ().transform;
	}

	// Update is called once per frame
	void Update () {
		if (this.stevie.position.z - this.transform.position.z > 10) {
			Vector3 newPos = Vector3.up * 1.5f;
			newPos.z = Mathf.Round (this.stevie.position.z + 15);
			newPos.x = Mathf.Round (Random.Range (-2, 3));
			this.transform.position = newPos;
		}


		if (Input.GetKeyDown (KeyCode.R)) {
			Time.timeScale = 1.0f;
			SceneManager.LoadScene (0);
		}
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
