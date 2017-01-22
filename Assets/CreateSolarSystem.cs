using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;


public class CreateSolarSystem : MonoBehaviour {

    public GameObject planetPrefab;
    public Vector3 center;
    public float planetsNumber = 1;
    public float defaultDistance = 1;

    void Start () {

        center = transform.position;
        UnityEngine.Random.InitState(DateTime.Now.Millisecond);

        for (int i = 0; i < planetsNumber; i++) {
            generatePlanet(defaultDistance * i, 30f * i);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void generatePlanet(float dist, float angle) {

    
        GameObject temp = Instantiate(planetPrefab, transform.position, Quaternion.identity);
        // Vector3 dir = Quaternion.AngleAxis(angle, Vector3.up) * Vector3.forward * dist;
        //temp.transform.Translate( dir );

        temp.transform.position = new Vector3(temp.transform.position.x + dist * (float)Math.Cos(angle),
            temp.transform.position.y + dist * (float)(Math.Sin(angle)), 0);
        temp.transform.SetParent(transform);
        
        
        /* float distanceToCenter = Vector3.Distance(temp.transform.position, center);
         temp.transform.SetParent(transform);
         temp.transform.position = new Vector3(distanceToCenter + dist,
                                                     distanceToCenter + dist,
                                                     0);*/

    }

}
