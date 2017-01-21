using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
    private PlayerMovement plrMovement;
    private float size = 1.0f;

	// Use this for initialization
	void Start () {
        plrMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();

        Debug.Log("FOund player" + plrMovement);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        plrMovement.ApplyGravity(transform.position, 1.0f);
	}
}
