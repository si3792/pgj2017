using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Upgrades/Health upgrade")]
public class HealthUpgrade : MonoBehaviour, IUpgrade {
    public GameObject player;
    public int level = 0;
    public int maxLevel = 3;
    public List<GameObject> upgradeLists;

    public void execute() {
        if (level + 1 > maxLevel) {
            return;
        }

        upgradeLists[level].SetActive(false);
        level++;
        upgradeLists[level].SetActive(true);
        // REDO THIS SHIT
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
