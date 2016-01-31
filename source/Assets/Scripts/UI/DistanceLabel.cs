using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DistanceLabel : MonoBehaviour {

	private Transform stevie;
	private Text text;

	// Use this for initialization
	void Start () {
		stevie = FindObjectOfType<Stevie> ().transform;
		text = this.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		int highScore = PlayerPrefs.GetInt ("HIGH_SCORE_1", 0);
		int currScore = Mathf.RoundToInt (stevie.position.z);

		string color = "#FFFFFF";

		if (currScore > highScore) {
			PlayerPrefs.SetInt ("HIGH_SCORE_1", currScore);
			highScore = currScore;
		}
		if (currScore == highScore) {
			color = "#f67687";
		}

		this.text.text = currScore + " METERS TRAVELLED\n<size=\"12\"><color=\"" + color + "\">LOCAL HIGH SCORE: " + highScore + " METERS</color></size>";
	}
}
