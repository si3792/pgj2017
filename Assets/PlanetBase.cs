using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBase : MonoBehaviour {

	public float size = 1f;
	public float density = 1f;
	private Transform playerTransform;
	private PlayerMovement playerMovement;

	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();

		transform.localScale = new Vector2(size, size);
	}

	void Update () {

		float distance = Vector3.Distance(playerTransform.position, transform.position);
		if(distance < GlobalData.gravityCutoffDistance) {
			playerMovement.ApplyGravity(transform.position, size * density);
		}
		
	}
}
