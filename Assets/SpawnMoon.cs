using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;

public class SpawnMoon : MonoBehaviour {

	public GameObject planetPrefab;
	public Vector3 center;
	public float spawnPercentage = 10;

	// Use this for initialization
	void Start () {

		if(transform.parent.gameObject.GetComponent<SpawnMoon>() == null)
		if(UnityEngine.Random.Range(0, 100) < spawnPercentage) {
			generatePlanet (transform.lossyScale.x * 10f, UnityEngine.Random.Range (0, 360), 
				(UnityEngine.Random.Range (0, 1) > 0.5) ? true : false, UnityEngine.Random.Range (0.2f, 1f), 
				transform.lossyScale.x / 3, UnityEngine.Random.Range (1, 5));
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void generatePlanet(float dist, float angle, bool clockwise, float rotSpeed, float size, float spin) {

		GameObject temp;
			temp = Instantiate(planetPrefab, transform.position, Quaternion.identity);
		// Vector3 dir = Quaternion.AngleAxis(angle, Vector3.up) * Vector3.forward * dist;
		//temp.transform.Translate( dir );

		temp.transform.position = new Vector3(temp.transform.position.x + dist * (float)Math.Cos(angle),
			temp.transform.position.y + dist * (float)(Math.Sin(angle)), 0);
		temp.GetComponent<PlanetController_new>().rotateClockwise = clockwise;
		temp.GetComponent<PlanetController_new>().rotationSpeed = rotSpeed;
		temp.GetComponent<Spin>().speed = spin;
		temp.transform.localScale = new Vector3(size, size, 1f);

		temp.transform.SetParent(transform);
		/* float distanceToCenter = Vector3.Distance(temp.transform.position, center);
         temp.transform.SetParent(transform);
         temp.transform.position = new Vector3(distanceToCenter + dist,
                                                     distanceToCenter + dist,
                                                     0);*/

	}
}
