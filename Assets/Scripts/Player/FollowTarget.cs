﻿using UnityEngine;
using System.Collections;

[AddComponentMenu("Scripts/Player/Camera Movement")]
public class FollowTarget : MonoBehaviour {

	public float interpVelocity;
	public float minDistance;
	public float followDistance;
    public float speed = 0.25f;
	public GameObject target;
	public Vector3 offset;
	Vector3 targetPos;
	// Use this for initialization
	void Start()
	{
		targetPos = transform.position;
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (target)
		{
			Vector3 posNoZ = transform.position;
			posNoZ.z = target.transform.position.z;

			Vector3 targetDirection = (target.transform.position - posNoZ);

			interpVelocity = targetDirection.magnitude * 5f;

			targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);
			targetPos = new Vector3(targetPos.x, targetPos.y, targetPos.z);
			transform.position = Vector3.Lerp(targetPos + offset, targetPos + offset, speed);
		}
	}

}
