using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuHandler : MonoBehaviour {

	public GameObject startScreen;
	public GameObject menuScreen;
	public GameObject creditsScreen;

	public CircleOpenerHandler circleOpenerHandler;

	public bool gameStarted = false;

	// Use this for initialization
	void Start () {

		this.circleOpenerHandler = GameObject.FindObjectOfType<CircleOpenerHandler>();

		this.startScreen.SetActive(true);
		this.menuScreen.SetActive(false);
		this.creditsScreen.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.startScreen.activeSelf && Input.anyKeyDown) {
			this.startScreen.SetActive(false);
			this.menuScreen.SetActive(true);
		} else if (this.menuScreen.activeSelf && Input.GetKeyDown(KeyCode.Return) && !this.circleOpenerHandler.circleOpener.activeSelf) {
			StartGameButtonPressed();
		}
	}

	// Menu clicks
	public void CreditsButtonPressed () {
		this.menuScreen.SetActive(false);
		this.creditsScreen.SetActive(true);
	}

	public void StartGameButtonPressed () {
		if (this.gameStarted == false) {
			this.gameStarted = true;
			StartCoroutine("StartGameWithDelay");
		}
	}

	public void CloseCreditsButtonPressed () {
		this.creditsScreen.SetActive(false);
		this.menuScreen.SetActive(true);
	}

	// Helpers
	IEnumerator StartGameWithDelay() {

		this.circleOpenerHandler.CloseCircle();

		yield return new WaitForSeconds(1.5f);

		SceneManager.LoadScene(1);
	}
}
