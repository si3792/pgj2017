using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/Player/Movement script")]
public class PlayerMovement : MonoBehaviour {
	public Rigidbody2D rb;

	public GameObject upFX;
	public GameObject victory;
	GameObject upgrController;


	public void ApplyGravity(Vector3 pos, float strength) {

		float distance = Vector3.Distance(pos, transform.position);
		if (distance <= 1) {
			distance = 1;
		}
        
		rb.AddForce((pos - transform.position).normalized * strength / distance );
	}
		
	void Start () {
		upgrController = GameObject.Find("UpgradesController");
	}

	void victoryy(){
		Instantiate (victory);
	}
		
	void FixedUpdate () {

		if(GlobalData.shipCharge >= 99) {
			// Updates here maybe?
			int upgrType = (UnityEngine.Random.Range(0f, 1f) > 0.5)? 0 : 1;

			GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ().sparkle ();

			if (upgrType == 0) {
				bool check = upgrController.GetComponent<HealthUpgrade>().execute();
				if(!check)
				if(!upgrController.GetComponent<SpeedUpgrade>().execute() )
				{
					// Victory
					victoryy();
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
						victoryy();
						Debug.Log("victory");
					}

				}

			GlobalData.shipCharge = 0;
			GlobalData.transmissionsSpied++;
		}

	}

	public void sparkle() {
		for(int i = 0;i < 6; i++)
			Instantiate (upFX, this.transform.position +  new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f), 0f), Quaternion.identity);

	}
}