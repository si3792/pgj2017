using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Upgrades/Speed upgrade")]
public class SpeedUpgrade : MonoBehaviour, IUpgrade {
    public GameObject player;
    public int level = 0;
    public int maxLevel = 3;
    public List<GameObject> upgradeLists;

    public bool execute() {
        if (level + 1 >= maxLevel) {
            return false;
        }


        upgradeLists[level].SetActive(false);
        level++;
        upgradeLists[level].SetActive(true);

        Debug.Log("UPGRADED Speed    " + level);
		return true;
    }
    
	// Use this for initialization
	void Start () {
       // execute();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
