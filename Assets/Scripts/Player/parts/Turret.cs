using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Ship/Turret")]
public class Turret : MonoBehaviour, IObjectDamage {
    // TODO: Rotation (arch)
    // TODO: Mirror rotation (flag)

    int health = 500;
    public int HP {
        get {
            return health;
        }
    }

    int maxHealth = 500;

    float nextFire = 0.0f;

    public GameObject projPrefab;

    public float fireCooldown = 0.5f;
    public int damage = 10;
    public float speed = 1.0f;
    public Vector2 direction = Vector2.zero;
    public float timeOut = 10.0f;
    float destroyTimer = 0.0f;

    // Use this for initialization
    void Start () {
		
	}
	
    void fireProjectiles() {
        GameObject obj = Instantiate(projPrefab);

        obj.transform.position = transform.TransformPoint(new Vector3(-0.05f, 0.28f, 0f));

        Projectile projectile = obj.GetComponent<Projectile>();
        projectile.direction = transform.forward;
        // TODO: Transfer stats
    }

	// Update is called once per frame
	void Update () {
        if (health == 0) {
            return;
        }

        if (Input.GetButton("Fire1")) {
            if (nextFire <= Time.time) {
                fireProjectiles();
                nextFire = Time.time + fireCooldown;
            }
        }
	}

    public void takeDamage(GameObject inflictor, int damage) {
        health = Mathf.Clamp(health - damage, 0, maxHealth);

        if (health == 0) {
            doDeath(inflictor);
        }
    }

    public void doDeath (GameObject inflictor) {
        // ANIMATIONS!!!
    }
}
