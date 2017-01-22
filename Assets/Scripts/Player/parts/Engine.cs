using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Ship/Engine")]
public class Engine : MonoBehaviour, IObjectDamage {
    public float maxHealth = 500;
    public float health = 500;
    public float rotationMultiplier = 0.1f;
    public float speedMultiplier = 2.0f;
    public float boostMultiplier = 5.5f;
    private Rigidbody2D rb;
    //public float boostCooldown = 3.0f;
    private float nextBoost = 0.0f;

    public bool active = true;

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
            GlobalData.engineOn = true;
        }
        else GlobalData.engineOn = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if ((health == 0) || (!active)) {
            return;
        }

        rb.AddTorque(Input.GetAxis("Horizontal") * rotationMultiplier * -1 * ((Input.GetButton("Jump") ? 0.6f : 1f)));

        // Controls 
        rb.AddForce(Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z) * new Vector2(0, Input.GetAxis("Vertical") * speedMultiplier * ((Input.GetButton("Jump") ? boostMultiplier : 1f))), ForceMode2D.Force);
    }

    public void takeDamage(GameObject inflictor, int damage) {
        health = Mathf.Clamp(health - damage, 0, maxHealth);

        if (health == 0) {
            doDeath(inflictor);
        }
    }

    public void doDeath(GameObject inflictor) {
        gameObject.SetActive(false);
        // DO STUFF HERE
    }
}
