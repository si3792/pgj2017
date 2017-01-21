using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Planets/Planet controller")]

public class PlanetController : MonoBehaviour {
    public GameObject sun; // PUBLIC FOR TESTING ONLY
    public Rigidbody2D rb;
    public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
    public void setSun(GameObject sun) {
        this.sun = sun;
    }
 
    void spinAroundSun() {
        transform.position = Vector2.Lerp(transform.position,
            transform.position + Quaternion.Euler(0,0,90.0f) * (sun.transform.position - transform.position).normalized,
            Time.deltaTime * speed);
            //rb.AddForce(Quaternion.Euler(0,0, 90.0f) * (sun.transform.position - transform.position).normalized * 10f);
    }

	// Update is called once per frame
	void FixedUpdate () {
        spinAroundSun();
	}
}
