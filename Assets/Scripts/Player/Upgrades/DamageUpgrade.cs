using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Upgrades/Damage upgrade")]
public class DamageUpgrade : MonoBehaviour, IUpgrade {
    public GameObject player;
    public int level = 1;
    public int maxLevel = 3;

    public void execute() {
        if (level + 1 > maxLevel) {
            return;
        }

        level++;
        player.GetComponentInChildren<Turret>().damage = player.GetComponentInChildren<Turret>().defDamage * level * GlobalData.damageUpgradeFactor;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
