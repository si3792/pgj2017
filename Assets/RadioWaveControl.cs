using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioWaveControl : MonoBehaviour {

    Color green = (new Vector4(0f, 1f, 0f, 1f));
    Color red = (new Vector4(1f, 0f, 0f, 1f));
    Color neutral = (new Vector4(1f, 1f, 1f, 1f));
    GameObject upgrController;
    
    public float charge = 100;
    

    void Start () {
        upgrController = GameObject.Find("UpgradesController");
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}



    public void finishTransmission() {
        // Updates here maybe?
		int upgrType = (UnityEngine.Random.Range(0f, 1f) > 0.5)? 0 : 1;
        


        if (upgrType == 0) {
            bool check = upgrController.GetComponent<HealthUpgrade>().execute();
			if(!check)
			if(!upgrController.GetComponent<SpeedUpgrade>().execute() )
			{
				// Victory
				Debug.Log("victory");
			}
				
        }
		else 
        if (upgrType == 1) {
			bool check = upgrController.GetComponent<SpeedUpgrade>().execute();
				if(!check)
				if(!upgrController.GetComponent<HealthUpgrade>().execute() )
				{
					// Victory
					Debug.Log("victory");
				}
					
        }

        GlobalData.shipCharge = 0;
        GlobalData.transmissionsSpied++;
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Hull") {
            foreach (Transform child in transform) {
                applyColor(child.gameObject.GetComponent<SpriteRenderer>(), green);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.tag == "Hull") {
            foreach (Transform child in transform) {
                applyColor(child.gameObject.GetComponent<SpriteRenderer>(), neutral);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.gameObject.tag == "Hull") {
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
