using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachedStarsScript : MonoBehaviour {

	public Transform target;

	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		this.transform.position = target.position;
	}
}
