using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuHandler : MonoBehaviour {

	public GameObject startScreen;
	public GameObject menuScreen;
	public GameObject creditsScreen;

	// Use this for initialization
	void Start () {
		this.startScreen.SetActive(true);
		this.menuScreen.SetActive(false);
		this.creditsScreen.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.startScreen.activeSelf && Input.anyKeyDown) {
			this.startScreen.SetActive(false);
			this.menuScreen.SetActive(true);
		}
	}

	// Menu clicks
	public void CreditsButtonPressed () {
		this.menuScreen.SetActive(false);
		this.creditsScreen.SetActive(true);
	}

	public void StartGameButtonPressed () {
		SceneManager.LoadScene(1);
	}

	public void CloseCreditsButtonPressed () {
		this.creditsScreen.SetActive(false);
		this.menuScreen.SetActive(true);
	}
}
