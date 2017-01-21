using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotationAndSize : MonoBehaviour {

	public bool randomizeRotation;
	public bool randomizeSize;
	public bool randomizeDepth = false;
	public float minSize= 1.0f;
	public float maxSize = 1.0f;
	public float minDepth;
	public float maxDepth;

	void Start () {
		if(randomizeRotation)transform.Rotate ( new Vector3(0, 0, Random.Range (0, 360)));
		if (randomizeSize) {
			float size = Random.Range (minSize, maxSize);
			transform.localScale = new Vector3 (size, size, 1); 
		}
		if(randomizeDepth) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, Random.Range(minDepth, maxDepth));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
