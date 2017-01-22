using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour {

	public GameObject wave;
	GameObject tmp ;
	// Use this for initialization
	void Start () {
		
	}

	void delayed() {
		tmp.GetComponent<RadioWaveControl> ().finishTransmission ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("p")){
			tmp = Instantiate(wave);
			Invoke ("delayed", 0.1f);
		}


		
	}
}
