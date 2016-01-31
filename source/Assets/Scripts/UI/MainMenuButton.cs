using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuButton : MonoBehaviour {

	public void ButtonCLicked () {
		FindObjectOfType<CircleOpenerHandler> ().CloseCircle();
		Invoke ("RestartLevel", 2.0f);
	}

	void RestartLevel() {
		SceneManager.LoadScene (0);
	}
}
