using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Ship/Engine")]
public class Engine : MonoBehaviour, IObjectDamage {
    public int maxHealth = 500;
    public int health = 500;
    public float rotationMultiplier = 0.1f;
    public float speedMultiplier = 1.0f;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = transform.parent.GetComponent<Rigidbody2D>();
	}
    
    private void Update() {
        if (health <= 0) {
            return;
        }

        if (Input.GetAxis("Horizontal") != 0) {
            // TODO: Animation
        }
        
        if (Input.GetAxis("Vertical") != 0) {
            // TODO: Animation
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (health <= 0) {
            return;
        }

        rb.AddTorque(Input.GetAxis("Horizontal") * rotationMultiplier * -1);

        // Controls 
        rb.AddForce(Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z) * new Vector2(0, Input.GetAxis("Vertical") * speedMultiplier), ForceMode2D.Force);
    }

    public void takeDamage(GameObject inflictor, int damage) {
        health = Mathf.Clamp(health - damage, 0, maxHealth);

        if (health == 0) {
            doDeath(inflictor);
        }
    }

    public void doDeath(GameObject inflictor) {
        // DO STUFF HERE
    }
}
