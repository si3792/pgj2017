using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;


public class CreateSolarSystem : MonoBehaviour {

    public GameObject planetPrefab;
	public GameObject radioPlanetPrefab;
    public Vector3 center;
    public float planetsNumber = 1;
    public float defaultDistance = 1;

    void Start () {

        center = transform.position;
        UnityEngine.Random.InitState(DateTime.Now.Millisecond);

        for (int i = 3; i < planetsNumber; i++) {
            float rotSpeed = UnityEngine.Random.Range(0.1f, 0.3f);
			generateRing( (int)(UnityEngine.Random.Range(1, 6)), defaultDistance * i, (UnityEngine.Random.value > 0.5f), rotSpeed);
       }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void generateRing(float numOfPlanets, float dist, bool clockwise, float rotSpeed) {

        float startAngle = UnityEngine.Random.Range(0f, 360f);
        float tmpAng = 360 / numOfPlanets;
        for (int i = 1; i <= numOfPlanets; i++) {
			generatePlanet(dist, i * tmpAng + startAngle, clockwise, rotSpeed, UnityEngine.Random.Range(1f, 2f), UnityEngine.Random.Range(0.1f, 2f), 
				(UnityEngine.Random.Range(0f, 100f) < GlobalData.radioChancePercentage)? true : false);
        }

    }


	void generatePlanet(float dist, float angle, bool clockwise, float rotSpeed, float size, float spin, bool isRadio) {

		GameObject temp;
		if(isRadio)
		 temp = Instantiate(radioPlanetPrefab, transform.position, Quaternion.identity);
		else
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
