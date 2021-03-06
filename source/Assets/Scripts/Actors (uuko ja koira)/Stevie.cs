﻿using UnityEngine;
using System.Collections;

public class Stevie : MonoBehaviour {

	public Animator stevieAnimator;
	public Transform stevieRotator;
	public AudioClip letsgo;
	public AudioClip bumpedToBox;
	public AudioClip[] coughs;
	public AudioClip[] stepSounds;
	public Transform stevieRagdoll;
	public int health = 5;

	private Rigidbody myRigidBody;
	private bool canPlayAudio = false;
	private bool hasStarted = false;

	void Start() {
		this.GetComponent<Rigidbody> ().velocity = Vector3.forward;
		this.myRigidBody = GetComponent<Rigidbody>();
		Invoke ("ReleaseAudio", 5.0f);
		Invoke("Cough", this.NextCoughDelay());
		PlayStepsSound ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		this.myRigidBody.AddForce (Vector3.forward * (hasStarted ? 10 : 0));

		// Prevents moving backwards 
		Vector3 vel = this.myRigidBody.velocity;
		vel.z = Mathf.Max (0, vel.z);
		this.myRigidBody.velocity = vel;
	}

	void ReleaseAudio() {
		canPlayAudio = true;
	}

	void PlayAudio(AudioClip clip, bool force = false) {
		if (!canPlayAudio && !force)
			return;
		canPlayAudio = false;
		Invoke ("ReleaseAudio", 5.0f);
		GetComponent<AudioSource> ().PlayOneShot(clip);
	}

	void Update() {
		if (!hasStarted) {
			if (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis ("Vertical") != 0) {
				hasStarted = true;
				PlayAudio (letsgo, true);
			}
		}

		// Calculate angle difference to the velocity so stevie "walks" also when he's only rotating
		float angleDiff = Vector3.Angle(stevieRotator.forward, this.myRigidBody.velocity);

		// Look at the direction where you're going
		stevieRotator.LookAt (this.transform.position + this.myRigidBody.velocity);
		stevieAnimator.speed = (this.myRigidBody.velocity.sqrMagnitude / 1.4f) + angleDiff;

		if (stevieAnimator.speed < 0.1f) {
			PlayAudio (letsgo);
		}
	}

	float NextCoughDelay() {
		return Random.Range (7.0f, 12.0f);
	}

	void Cough() {
		AudioClip cough = coughs[Mathf.FloorToInt(Random.Range(0, coughs.Length))];
		PlayAudio (cough);
		Invoke("Cough", this.NextCoughDelay());
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.GetComponent<Obstacle> () != null) {
			GetComponent<AudioSource> ().PlayOneShot(bumpedToBox);
		}
	}

	void PlayStepsSound() {
		AudioClip clip = stepSounds[Mathf.FloorToInt(Random.Range(0, stepSounds.Length))];
		GetComponent<AudioSource> ().PlayOneShot(clip);
		Invoke ("PlayStepsSound", clip.length);
	}

	public void LoseHealth(int amount, Vector3 atPoint) {
		this.health = Mathf.Max (0, this.health - amount);
		Debug.Log ("Stevie's health: " + this.health);
		if (this.health == 0) {
			this.Die (atPoint, 15.0f * amount);
		}
	}

	void Die(Vector3 atPoint, float amount) {
		Transform ragdoll = (Transform)Instantiate (stevieRagdoll, stevieAnimator.transform.position, stevieAnimator.transform.rotation);
		Rigidbody[] ragdollBodies = ragdoll.GetComponentsInChildren<Rigidbody> ();
		foreach (Rigidbody ragdollBody in ragdollBodies) {
			ragdollBody.AddExplosionForce (amount, atPoint, 2.0f);
		}

		Debug.Log ("Game Over");
		Debug.Log ("Your score: " + Mathf.Round(transform.position.z));
		//Time.timeScale = 0;

		Camera.main.transform.parent = null;

		CancelInvoke ();

		this.gameObject.SetActive (false);
	}
}
