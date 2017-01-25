using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/User interface/Health bar")]
public class HPBar : MonoBehaviour {
    public GameObject player;
    public PlayerShip ship;
    public Slider slider;
	public bool radarBarInstead = false;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        slider = GetComponent<Slider>();
        ship = player.GetComponentInChildren<PlayerShip>();
        Debug.Log(ship);
	}
	
	// Update is called once per frame
	void Update () {
		if(radarBarInstead)slider.value = GlobalData.shipCharge / 100f;   
        else slider.value = ship.health / ship.maxHealth;
	}
}
