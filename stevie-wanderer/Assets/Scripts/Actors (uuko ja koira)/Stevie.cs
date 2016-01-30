using UnityEngine;
using System.Collections;

public class Stevie : MonoBehaviour {

	public Animator stevieAnimator;
	public Transform stevieRotator;

	private Rigidbody myRigidBody;

	void Start() {
		this.GetComponent<Rigidbody> ().velocity = Vector3.forward;
		this.myRigidBody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		this.myRigidBody.AddForce (Vector3.forward * 10);

		// Prevents moving backwards 
		Vector3 vel = this.myRigidBody.velocity;
		vel.z = Mathf.Max (0, vel.z);
		this.myRigidBody.velocity = vel;
	}

	void Update() {
		// Calculate angle difference to the velocity so stevie "walks" also when he's only rotating
		float angleDiff = Vector3.Angle(stevieRotator.forward, this.myRigidBody.velocity);

		// Look at the direction where you're going
		stevieRotator.LookAt (this.transform.position + this.myRigidBody.velocity);
		stevieAnimator.speed = (this.myRigidBody.velocity.sqrMagnitude / 1.4f) + angleDiff;
	}
}
