using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody2D rb;
    public float rotationMultiplier = 0.1f;
    public float speedMultiplier = 1.0f;

    public void ApplyGravity(Vector3 pos, float size) {
        float distance = Vector2.Distance(pos, transform.position);

        rb.AddForce((pos - transform.position) * distance)  ;
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
