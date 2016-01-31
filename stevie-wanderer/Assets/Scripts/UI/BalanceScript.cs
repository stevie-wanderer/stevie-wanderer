using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BalanceScript : MonoBehaviour {
	
	private Stevie stevie;
	private int fullHealth;
	private Text text;

	// Use this for initialization
	void Start () {
		stevie = FindObjectOfType<Stevie> ();
		fullHealth = stevie.health;
		text = this.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.text.text = "STEVIE'S BALANCE: " + Mathf.Round(100.0f * stevie.health / fullHealth) + " %";
	}
}
