using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defeatControl : MonoBehaviour {

	public Transform camera;
	// Use this for initialization
	void Start () {

		camera = GameObject.FindGameObjectWithTag ("MainCamera").transform;
		transform.parent = camera;
	}

	void switchRoom() {
		Application.LoadLevel ("menu");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3 (camera.position.x, camera.position.y, camera.position.z + 10); 
		camera.transform.Translate (0f, 0f, -0.7f);
		Invoke ("switchRoom", 4f);
	}
}
