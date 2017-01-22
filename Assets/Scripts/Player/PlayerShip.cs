using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour, IObjectDamage, IDamageInflictor {
    public float maxHealth = 500;
    public float defMaxHealth = 500;
    public float health = 500;
    public float defHealth = 500;
    public List<GameObject> turretGroups;


    public void takeDamage(GameObject inflictor, int damage) {
        health = Mathf.Clamp(health - damage, 0, maxHealth);
        GlobalData.shake = true;
        if (health == 0) {
            doDeath(inflictor);
        }
    }

    public void doDeath(GameObject inflictor) {
        IDamageInflictor killer = inflictor.GetComponent<IDamageInflictor>();
        Destroy(this.gameObject);
        // killer.kill(gameObject);
        // END GAME
    }

    public void dealDamage(GameObject victim, float damage) {
        // IDK
    }

    public void kill(GameObject victim) {
        // IDK
    }

    void randomTurrets() {
        turretGroups[UnityEngine.Random.Range(0, 2)].SetActive(true);
    }

	// Use this for initialization
	void Start () {
        randomTurrets();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
