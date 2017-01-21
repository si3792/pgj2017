using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUpgrade : MonoBehaviour, IUpgrade {
    public GameObject player;
    public int level = 1;
    public int maxLevel = 3;

    public void execute() {
        player.GetComponent<PlayerShip>().maxHealth = player.GetComponent<PlayerShip>().defMaxHealth * level * GlobalData.HealthUpgradeFactor;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
