using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Player/Movement script")]
public class PlayerMovement : MonoBehaviour {
	public Rigidbody2D rb;
	public float rotationMultiplier = 0.1f;
	public float speedMultiplier = 1.0f;

	public void ApplyGravity(Vector3 pos, float size, float planetSize) {
		float distance = Vector3.Distance(pos, transform.position);
        
		if (distance <= 1) {
			distance = 1;
		}
        
		// Increase gravity when nearby - doesn't work for whatever reason
		if(distance < 10 * planetSize) distance *= 100;

        rb.AddForce((pos - transform.position).normalized * size / distance );
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		rb.AddTorque(Input.GetAxis("Horizontal") * rotationMultiplier * -1);

		// Controls 
		rb.AddForce(Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z) * new Vector2(0, Input.GetAxis("Vertical") * speedMultiplier), ForceMode2D.Force);

		// TODO: Add gravity
	}
}