using UnityEngine;
using System.Collections;

public class RandomSoundPlayer : MonoBehaviour {

	public AudioClip[] randomSounds;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("PlaySound", 0.5f, 4.0f);
	}

	void PlaySound() {
		GetComponent<AudioSource> ().PlayOneShot (randomSounds [Mathf.FloorToInt (Random.Range (0, randomSounds.Length))]);
	}

}
