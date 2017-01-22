using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Planets/Planet controller new")]
public class PlanetController_new : MonoBehaviour {

	public float rotationSpeed = 0.1f;
	public bool rotateClockwise = true;
	private GameObject sun; // The object we rotate around
	private Rigidbody2D rb;
    public bool isSun = false;

	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody2D> ();

        if (this.gameObject.GetComponent<Transform>().parent == null) {
            isSun = true;
            return;
        }

        sun = this.gameObject.GetComponent<Transform> ().parent.gameObject;
	}
	
	void rotateAroundSun() {

        /*transform.position = Vector2.Lerp(transform.position,
			transform.position + Quaternion.Euler(0,0, ((rotateClockwise)? -90f:90f)) * (sun.transform.position - transform.position).normalized,
			Time.deltaTime * rotationSpeed);
		*/

		float sine = Mathf.Sin( ((rotateClockwise)? -1 : 1) * rotationSpeed * GlobalData.rotationFactor);
		float cosine = Mathf.Cos(((rotateClockwise) ? -1 : 1) * rotationSpeed * GlobalData.rotationFactor);

        Vector2 temp = new Vector2(transform.position.x - sun.transform.position.x, transform.position.y - sun.transform.position.y);

        transform.position = new Vector2(
            (temp.x * cosine - temp.y * sine) + sun.transform.position.x,
            (temp.x * sine + temp.y * cosine) + sun.transform.position.y);
    }

	void FixedUpdate () {

		if(sun != null) 
		rotateAroundSun ();
	}
		

}
