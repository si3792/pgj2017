using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[AddComponentMenu("Scripts/User interface/Play button")]
public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void doCLick() {
        
		GlobalData.transmissionsSpied = 0;
		SceneManager.LoadScene(1);
	}
}
