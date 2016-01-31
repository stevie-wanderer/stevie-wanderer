using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RagdollGameEnder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		FindObjectOfType<CircleOpenerHandler> ().CloseCircleAfter (2.0f);
		Invoke ("RestartLevel", 3.5f);
	}

	void RestartLevel() {
		SceneManager.LoadScene (1);
	}
}
