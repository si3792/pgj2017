using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioWaveControl : MonoBehaviour {

    Color green = (new Vector4(0f, 1f, 0f, 1f));
    Color red = (new Vector4(1f, 0f, 0f, 1f));
    Color neutral = (new Vector4(1f, 1f, 1f, 1f));

    public float charge = 100;
    

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void finishTransmission() {
        // Updates here maybe?

        GlobalData.transmissionsSpied++;
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player") {
            foreach (Transform child in transform) {
                applyColor(child.gameObject.GetComponent<SpriteRenderer>(), green);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            foreach (Transform child in transform) {
                applyColor(child.gameObject.GetComponent<SpriteRenderer>(), neutral);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            if (charge > 0) {
                charge -= GlobalData.chargeDrainFactor;
                GlobalData.shipCharge += GlobalData.chargeDrainFactor;
            }
            else finishTransmission();
            
        }
    }

    private void applyColor(SpriteRenderer sr, Color c) {
        sr.color = c;
    }
}
