using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;

[AddComponentMenu("Scripts/Planets/Planet generator")]
class PlanetSpawner : MonoBehaviour{
    public GameObject planetPrefab;
    public GameObject sunPrefab;

    public float maxUnits = 100.0f;
    public int planets = 2;
    public Vector3 center = Vector3.zero;

    private void Start() {
        generatePlanets(maxUnits, planets, center);
    }

    private void FixedUpdate() {

    }

    GameObject createSun(float maxUnits, Vector3 center) {
        GameObject sun = Instantiate(sunPrefab);

        UnityEngine.Random.InitState(DateTime.Now.Millisecond);

        sun.transform.position = center;
        float size = UnityEngine.Random.Range(1.0f, 3.0f);
        Gravity tempGravity = sun.GetComponentInChildren<Gravity>();
        tempGravity.size = size;
        tempGravity.density = 10.0f;

        return sun;
    }

    void generatePlanets(float maxUnits, int planets, Vector3 center) {
        Debug.Log(maxUnits + " " + center);

        GameObject sun = createSun(maxUnits, center);

        float distanceToCenter = sun.GetComponentInChildren<SpriteRenderer>().bounds.size.x * 0.5f;

        for (int i = 0; i<planets; i++) {
            UnityEngine.Random.InitState( DateTime.Now.Millisecond); // DO NOT REMOVE THIS LINE!!!

            GameObject temp = Instantiate(planetPrefab);

            float size = UnityEngine.Random.Range(1.0f, 3.0f);

            Gravity tempGravity = temp.GetComponentInChildren<Gravity>();
            tempGravity.size = size;

            PlanetController tempController = temp.GetComponent<PlanetController>();
            tempController.setSun(sun);
            tempController.speed = UnityEngine.Random.Range(1.0f, 30.0f);
            tempGravity.density = Mathf.Clamp(tempController.speed * 0.2f, 1.0f, 10.0f);

            UnityEngine.Random.InitState(DateTime.Now.Millisecond);

            float orbitRadius = UnityEngine.Random.Range(size * 4.5f * 2, size * 4.5f * UnityEngine.Random.Range(4.0f, 10.0f));

            temp.transform.position = new Vector3(  distanceToCenter + orbitRadius,
                                                    distanceToCenter + orbitRadius,
                                                    0);

            distanceToCenter = Vector3.Distance(temp.transform.position, center);

            Debug.Log(orbitRadius);
            Debug.Log(distanceToCenter);
            /*temp.transform.position = new Vector3(  UnityEngine.Random.Range(center.x - maxUnits, center.x + maxUnits),
                                                    UnityEngine.Random.Range(center.y - maxUnits, center.y + maxUnits),
                                                    0   );*/
        }

    }
}
