﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceFromPlanets : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Rotatable") {
            Destroy(this.gameObject);
        }
    }

}
