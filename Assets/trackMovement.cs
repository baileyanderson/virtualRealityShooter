using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackMovement : MonoBehaviour {

	int maxZ = 5;
	bool rotated = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < 2 && !rotated) {
			Camera.main.transform.Rotate (new Vector3 (0, 270, 0));
			rotated = true;
			return;
		} else if (rotated) {
			return;
		}
		transform.position = transform.position + new Vector3(-0.001f, 0, 0);
	}
}
