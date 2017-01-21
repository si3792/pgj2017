using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Planets/Gravity")]
public class Gravity : MonoBehaviour {
    private PlayerMovement plrMovement;
    public float size = 1.0f; // Set the size using this float and apply visual scaling through the script (useful for the planet generation
	public float density = 1.0f;
	private float planetSize = 4.5f; // Sprite radius in world units

	// Use this for initialization
	void Start () {
        plrMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        computeSize();
    }

    public void computeSize() {
        //planetSize = this.gameObject.GetComponent<Transform> ().localScale.x;
        transform.localScale = new Vector2(size, size);
        Debug.Log(transform.GetComponent<SpriteRenderer>().bounds.size.x);
        //transform.parent.GetComponent<CircleCollider2D>().radius = transform.parent.GetComponent<SpriteRenderer>().bounds.size.x * 0.5f;
    }

    // Update is called once per frame
    void FixedUpdate () {
		plrMovement.ApplyGravity(transform.position, size * density);
	}
}
