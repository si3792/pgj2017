using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Upgrades/Speed upgrade")]
public class SpeedUpgrade : MonoBehaviour, IUpgrade {
    public GameObject player;
    public int level = 1;
    public int maxLevel = 3;

    public void execute() {
        if (level + 1 > maxLevel) {
            return;
        }
        level++;

        player.GetComponentInChildren<Engine>().speedMultiplier = player.GetComponentInChildren<Engine>().defSpeed *  level * GlobalData.speedUpgradeFactor;
    }
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
