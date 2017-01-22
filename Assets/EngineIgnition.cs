using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineIgnition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<SpriteRenderer>().enabled = GlobalData.engineOn;
	}
}
