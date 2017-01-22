using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceFromPlanets : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Rotatable") {
            Vector3 dir = -(col.gameObject.transform.position - this.gameObject.transform.position).normalized;
            this.GetComponent<Rigidbody2D>().AddForce(dir * GlobalData.bounceFactor);
            this.GetComponent<PlayerShip>().takeDamage(col.gameObject, GlobalData.dmgOnHit);
        }
    }

}
