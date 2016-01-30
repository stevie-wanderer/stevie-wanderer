using UnityEngine;
using System.Collections;

public class Dog : MonoBehaviour {

	public Vector3 velocity = Vector3.zero;
	private const float MAX_HIHNA_LENGTH = 5.0f;
	Transform stevie;
	public Animator dogeAnimator;

	private bool canPlayAudio = false;

	//int ANIM_WALK = Animator.StringToHash("Walk");
	//int ANIM_IDLE = Animator.StringToHash("Idle");

	// Use this for initialization
	void Start () {
		stevie = FindObjectOfType<Stevie> ().transform;
		Invoke ("ReleaseAudio", 5.0f);
	}

	void FixedUpdate() {

		this.velocity = Vector3.zero;

		this.velocity += Input.GetAxis ("Horizontal") * -Vector3.forward;
		this.velocity += Input.GetAxis ("Vertical") * Vector3.right;

		float multiplier = 4.0f;
		float zDiff = Mathf.Abs(stevie.position.z - transform.position.z);

		if (zDiff > MAX_HIHNA_LENGTH) {
			multiplier = Mathf.Max(0.0f, 4.0f - (zDiff - MAX_HIHNA_LENGTH));

			if (zDiff > MAX_HIHNA_LENGTH + 1.5f) {
				PlayAudio ();
			}
		} else if (Vector3.Distance (transform.position, stevie.position) > MAX_HIHNA_LENGTH && !(velocity.z < 0.0f && zDiff > -0.1f)) {
			//multiplier = 1.0f;
		}

		this.GetComponent<Rigidbody> ().velocity = this.velocity * multiplier;

		this.transform.LookAt (this.transform.position + this.velocity);
	}
	
	// Update is called once per frame
	void Update () {
		dogeAnimator.SetFloat ("Speed", this.GetComponent<Rigidbody> ().velocity.sqrMagnitude * 0.7f);

		/*AnimatorStateInfo animatorState = dogeAnimator.GetCurrentAnimatorStateInfo (0);

		if (this.GetComponent<Rigidbody> ().velocity.sqrMagnitude < 1 && animatorState == ANIM_WALK) {
			dogeAnimator.SetTrigger (ANIM_IDLE);
			Debug.Log ("Idlig ... " + Time.time);
		} else if(this.GetComponent<Rigidbody> ().velocity.sqrMagnitude > 1 && animatorState == ANIM_IDLE) {
			dogeAnimator.Set
			Debug.Log ("Walking ... " + Time.time);
		}*/
	}

	void ReleaseAudio() {
		canPlayAudio = true;
	}

	void PlayAudio() {
		if (!canPlayAudio)
			return;
		canPlayAudio = false;
		Invoke ("ReleaseAudio", 5.0f);
		GetComponent<AudioSource> ().Play ();
	}
}
