using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CityBuilder : MonoBehaviour {

	public GameObject[] cityBlocks;
	private List<GameObject> cityBlockCache = new List<GameObject>();
	private Transform stevie;
	private float BLOCK_WIDTH = 14.8f;

	// Use this for initialization
	void Start () {
		stevie = FindObjectOfType<Stevie> ().transform;

		for (int i = 0; i < 6; i++) {
			GameObject newBlock = (GameObject)Instantiate (cityBlocks [0]);
			cityBlockCache.Add (newBlock);
		}

		UpdateBlocks ();

		InvokeRepeating("CheckSteviePosition", 5.0f, 5.0f);
	}

	void UpdateBlocks() {
		float stevieZ = Mathf.Round(stevie.position.z / BLOCK_WIDTH) * BLOCK_WIDTH;

		int i = -1;
		foreach (GameObject block in cityBlockCache) {
			Vector3 pos = block.transform.position;
			pos.z = stevieZ + (i * BLOCK_WIDTH);
			block.transform.position = pos;
			i++;
		}
	}

	private float lastSteviePositionZ = 0.0f;
	void CheckSteviePosition() {
		if (Mathf.Abs (stevie.position.z - lastSteviePositionZ) > BLOCK_WIDTH) {
			UpdateBlocks ();
			lastSteviePositionZ = stevie.position.z;
		}
	}
}
