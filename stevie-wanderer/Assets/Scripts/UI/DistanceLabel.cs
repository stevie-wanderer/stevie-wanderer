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
		this.text.text = Mathf.Round(stevie.position.z) + " METERS TRAVELLED";
	}
}
