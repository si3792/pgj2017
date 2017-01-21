using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Planets/Sun physics")]
public class Sun : MonoBehaviour {
    public List<GameObject> planets;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

    public void init(int planetCount) {
        planets = new List<GameObject>(planetCount);
    }

    public void addPlanet( GameObject planet) {
        planets.Add(planet);
    }
}
