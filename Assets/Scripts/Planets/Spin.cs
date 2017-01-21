using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Planets/Spin")]
public class Spin : MonoBehaviour {

	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.GetComponent<Transform> ().Rotate (new Vector3 (0, 0, speed));
	}
}
