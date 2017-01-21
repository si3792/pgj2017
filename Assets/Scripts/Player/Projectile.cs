using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Ship/Projectile controller")]
public class Projectile : MonoBehaviour {
    public Rigidbody2D rb;
    public int damage = 10;
    public float speed = 1.0f;
    public Vector2 direction = Vector2.zero;
    public float timeOut = 10.0f;
    float destroyTimer = 0.0f;

    // Use this for initialization
    void Start () {
        destroyTimer = Time.time + timeOut;
	}

    private void Update() {
        if (Time.time >= destroyTimer) {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        rb.velocity = direction * speed;
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        IObjectDamage dmg = collision.gameObject.GetComponent<IObjectDamage>();
        dmg.takeDamage(this.gameObject, damage);
        Destroy(gameObject);
    }
}
