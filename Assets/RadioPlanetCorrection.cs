using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioPlanetCorrection : MonoBehaviour {

	void selfCorrect() {
		
	}

	// Use this for initialization
	void Start () {
		Invoke("selfCorrect", 1);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Spin> ().speed = Random.Range (0.1f, 0.8f);
		GetComponent<PlanetController_new> ().rotationSpeed = Random.Range (0.02f, 0.06f);
	}
}
