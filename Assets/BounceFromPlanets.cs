using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceFromPlanets : MonoBehaviour {

    public GameObject smokeFX;
	void Start () {
		
	}
	

	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Rotatable") {
            Vector3 dir = -(col.gameObject.transform.position - this.gameObject.transform.position).normalized;
            this.GetComponent<Rigidbody2D>().AddForce(dir * GlobalData.bounceFactor);
            this.GetComponentInChildren<PlayerShip>().takeDamage(col.gameObject, GlobalData.dmgOnHit);

            foreach (ContactPoint2D cp in col.contacts) {
                Vector2 hitPoint = cp.point;
                Instantiate(smokeFX, new Vector3(hitPoint.x, hitPoint.y, 0), Quaternion.identity);
                Instantiate(smokeFX, new Vector3(hitPoint.x, hitPoint.y, 0), Quaternion.identity);
            }
        }
    }

}
