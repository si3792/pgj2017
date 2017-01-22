using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDeath : MonoBehaviour {
    
    public float seconds;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, seconds);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
