using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIHackCell : MonoBehaviour {

	public int required = 1;

	void Start () {
		gameObject.GetComponent<Image> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		if (required <= GlobalData.transmissionsSpied)
			gameObject.GetComponent<Image> ().enabled = true;
	}
}
