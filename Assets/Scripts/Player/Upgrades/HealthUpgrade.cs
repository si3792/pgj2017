using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Upgrades/Health upgrade")]
public class HealthUpgrade : MonoBehaviour, IUpgrade {
    public GameObject player;
    public int level = 1;
    public int maxLevel = 3;

    public void execute() {
        if (level + 1 > maxLevel) {
            return;
        }

        level++;
        player.GetComponent<PlayerShip>().maxHealth = player.GetComponent<PlayerShip>().defMaxHealth * level * GlobalData.healthUpgradeFactor;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
