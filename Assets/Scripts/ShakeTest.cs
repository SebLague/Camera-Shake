using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeTest : MonoBehaviour {

	public CameraShake.Properties testProperties;


	void Update() {
		if (Input.GetKeyDown (KeyCode.Space)) {
			FindObjectOfType<CameraShake>().StartShake (testProperties);
		}
	}
}
