using UnityEngine;
using System.Collections;

public class CircleOpenerHandler : MonoBehaviour {

	public GameObject circleOpener;

	public void CloseCircle () {
		StartCoroutine("CloseCircleCoroutine");
	}

	IEnumerator CloseCircleCoroutine() {

		this.circleOpener.SetActive(true);

		float elapsedTime = 0;
		float time = 1.0f;

		while (elapsedTime < time) {
			float newLocalScale = Mathf.Lerp(2000, 0.85f, (elapsedTime / time));
			elapsedTime += Time.deltaTime;

			this.circleOpener.transform.localScale = new Vector3(newLocalScale,newLocalScale,newLocalScale);

			yield return new WaitForEndOfFrame();
		}
	}

	public void OpenCircle () {
		StartCoroutine("OpenCircleCoroutine");
	}

	IEnumerator OpenCircleCoroutine() {

		this.circleOpener.SetActive(true);

		float elapsedTime = 0;
		float time = 2.0f;

		while (elapsedTime < time) {
			float newLocalScale = Mathf.Lerp(0.85f, 2000, (elapsedTime / time));
			elapsedTime += Time.deltaTime;

			this.circleOpener.transform.localScale = new Vector3(newLocalScale,newLocalScale,newLocalScale);

			yield return new WaitForEndOfFrame();
		}

		this.circleOpener.SetActive(false);
	}
}
