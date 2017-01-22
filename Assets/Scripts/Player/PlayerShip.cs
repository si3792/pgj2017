using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour, IObjectDamage, IDamageInflictor {
    public float maxHealth = 500;
    public float health = 500;
    public List<GameObject> turretGroups;
	public GameObject smokeFX, sparkFx, defeat;


    public void takeDamage(GameObject inflictor, int damage) {
        health = Mathf.Clamp(health - damage, 0, maxHealth);
        GlobalData.shake = true;
        if (health == 0) {
            doDeath(inflictor);
        }
    }




    public void doDeath(GameObject inflictor) {

		for(int i = 0;i < 4; i++)
			Instantiate (sparkFx, this.transform.position + new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f), 0f), Quaternion.identity);


		for(int i = 0;i < 6; i++)
			Instantiate (smokeFX, this.transform.position +  new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f), 0f), Quaternion.identity);

        IDamageInflictor killer = inflictor.GetComponent<IDamageInflictor>();

		Instantiate (defeat);
        Destroy(transform.parent.gameObject, 0.1f);


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
