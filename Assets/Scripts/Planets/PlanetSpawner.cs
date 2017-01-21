using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;

class PlanetSpawner : MonoBehaviour{
    public GameObject planetPrefab;

    private void Start() {
        
    }

    private void FixedUpdate() {

    }

    void generate(float maxUnits, int planets, Vector3 center) {
        for (int i = 0; i<planets; i++) {
            GameObject temp = Instantiate(planetPrefab);

            // WIP
            //temp.transform.position = new Vector3(UnityEngine.Random.Range(maxUnits, maxUnits * 2) - maxUnits);
        }

    }
}
