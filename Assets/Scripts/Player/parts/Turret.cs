using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Ship/Turret")]
public class Turret : MonoBehaviour, IObjectDamage {

    public float health = 500;
    
    int maxHealth = 500;

    float nextFire = 0.0f;

    public GameObject projPrefab;

    public bool active = true;
    public float fireCooldown = 0.5f;
    public float damage = 10.0f;
    public float speed = 1.0f;
    public Vector2 direction = Vector2.zero;
    public float timeOut = 10.0f;
    public bool left = false;
    float destroyTimer = 0.0f;

    // Use this for initialization
    void Start () {
		
	}
	
    void fireProjectiles() {
        GameObject obj = Instantiate(projPrefab);

        obj.transform.position = transform.TransformPoint(new Vector3(-0.05f, 0.28f, 0f));
        obj.transform.rotation = transform.rotation;

        Projectile projectile = obj.GetComponent<Projectile>();
        obj.GetComponent<Rigidbody2D>().AddForce(Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + 90) * new Vector2(200 * speed, 0));
        // TODO: Transfer stats
    }

	// Update is called once per frame
	void Update () {
        if ((health == 0) || (!active)) {
            return;
        }

        if (Input.GetButton("Fire1") && (left)) {
            if (nextFire <= Time.time) {
                fireProjectiles();
                nextFire = Time.time + fireCooldown;
                return;
            }
            return;
        }

        if (Input.GetButton("Fire2") && (!left)) {
            if (nextFire <= Time.time) {
                fireProjectiles();
                nextFire = Time.time + fireCooldown;
                return;
            }
            return;
        }
	}

    public void takeDamage(GameObject inflictor, int damage) {
        health = Mathf.Clamp(health - damage, 0, maxHealth);

        if (health == 0) {
            doDeath(inflictor);
        }
    }

    public void doDeath (GameObject inflictor) {
        gameObject.SetActive(false);
        // ANIMATIONS!!!
    }
}
