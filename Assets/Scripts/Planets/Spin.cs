using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Planets/Spin")]
public class Spin : MonoBehaviour {

	public float speed = 0.1f;
    private float dir = 1;
    // Use this for initialization
    void Start () {
        if (Random.Range(0f, 1f) > 0.5) dir = -1;
    }
	
	// Update is called once per frame
	void Update () {        
		this.gameObject.GetComponent<Transform> ().Rotate (new Vector3 (0, 0, speed * dir));
	}
}
