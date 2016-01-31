using UnityEngine;
using System.Collections;

public class TutorialHider : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Vertical") != 0 || Input.GetAxis ("Horizontal") != 0) {
			this.gameObject.SetActive (false);
		}
	}
}
