using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
    private PlayerMovement plrMovement;
    private float size = 1.0f;
	public float density = 1.0f;
	private float planetSize;

	// Use this for initialization
	void Start () {
        plrMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();

		planetSize = this.gameObject.GetComponent<Transform> ().localScale.x;
		size *= planetSize;
        Debug.Log("FOund player" + plrMovement);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		plrMovement.ApplyGravity(transform.position, size * density, planetSize);
	}
}
