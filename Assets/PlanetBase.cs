using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBase : MonoBehaviour {

	public float size = 1f;
	public float density = 1f;
	private Transform playerTransform;
	private PlayerMovement playerMovement;

	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>;
		playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
	}

	void Update () {

		float distance = Vector3.Distance(pos, transform.position);
		if(distance < GlobalData.gravityCutoffDistance) {
			playerMovement.ApplyGravity(transform.position, size * density);
		}
		
	}
}
