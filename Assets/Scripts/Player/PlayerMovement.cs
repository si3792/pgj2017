using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Player/Movement script")]
public class PlayerMovement : MonoBehaviour {
	public Rigidbody2D rb;

	public GameObject upFX;
	public void ApplyGravity(Vector3 pos, float strength) {

		float distance = Vector3.Distance(pos, transform.position);
		if (distance <= 1) {
			distance = 1;
		}
        
		rb.AddForce((pos - transform.position).normalized * strength / distance );
	}
		
	void Start () {

	}
		
	void FixedUpdate () {
		

	}

	public void sparkle() {
		for(int i = 0;i < 6; i++)
			Instantiate (upFX, this.transform.position +  new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f), 0f), Quaternion.identity);

	}
}