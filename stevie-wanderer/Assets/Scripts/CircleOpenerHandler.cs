using UnityEngine;
using System.Collections;

public class CircleOpenerHandler : MonoBehaviour {

	public GameObject circleOpener;

	private float maxScaleValue = 2000.0f;
	private float minScaleValue = 0.85f;

	void Start () {

		this.GetComponent<Camera>().enabled = true;

		OpenCircle();
	}

	public void CloseCircle () {
		StartCoroutine("CloseCircleCoroutine");
	}

	public void CloseCircleAfter(float time) {
		Invoke ("CloseCircle", time);
	}

	IEnumerator CloseCircleCoroutine() {

		this.circleOpener.SetActive(true);

		float elapsedTime = 0.0f;
		float time = 1.0f;

		while (this.circleOpener.transform.localScale.x > this.minScaleValue) {
			float newLocalScale = Mathf.Lerp(this.maxScaleValue, this.minScaleValue, (elapsedTime / time));
			elapsedTime += Time.deltaTime;

			this.circleOpener.transform.localScale = new Vector3(newLocalScale,newLocalScale,newLocalScale);

			AudioListener.volume *= 0.97f;

			yield return new WaitForEndOfFrame();
		}
	}

	public void OpenCircle () {
		StartCoroutine("OpenCircleCoroutine");
	}

	IEnumerator OpenCircleCoroutine() {

		this.circleOpener.SetActive(true);

		float elapsedTime = 0.0f;
		float time = 2.5f;

		while (this.circleOpener.transform.localScale.x < this.maxScaleValue) {
			float newLocalScale = Mathf.Lerp(this.minScaleValue, this.maxScaleValue, (elapsedTime / time));
			elapsedTime += Time.deltaTime;

			this.circleOpener.transform.localScale = new Vector3(newLocalScale,newLocalScale,newLocalScale);

			AudioListener.volume = Mathf.Min(0.5f, AudioListener.volume / 0.97f);

			yield return new WaitForEndOfFrame();
		}

		this.circleOpener.SetActive(false);
	}
}
