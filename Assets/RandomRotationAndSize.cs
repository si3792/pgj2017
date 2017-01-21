using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotationAndSize : MonoBehaviour {

	public bool randomizeRotation;
	public bool randomizeSize;
	public float minSize= 1.0f;
	public float maxSize = 1.0f;

	void Start () {
		if(randomizeRotation)transform.Rotate ( new Vector3(0, 0, Random.Range (0, 360)));
		if (randomizeSize) {
			float size = Random.Range (minSize, maxSize);
			transform.localScale = new Vector3 (size, size, 1); 
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
