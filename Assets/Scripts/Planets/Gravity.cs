using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
    private PlayerMovement plrMovement;
    private Transform plrTransform;
    private float size = 1.0f;

	// Use this for initialization
	void Start () {
        plrMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        plrTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Debug.Log("FOund player" + plrMovement);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        plrMovement.ApplyGravity(plrTransform.transform.position, 1.0f);
	}
}
