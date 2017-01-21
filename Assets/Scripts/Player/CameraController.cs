using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/Player/Mini map")]
public class CameraController : MonoBehaviour {
    public GameObject renderPanel;
    public Camera mapCamera;

	// Use this for initialization
	void Start () {
        Image img = renderPanel.GetComponent<Image>();
        mapCamera.targetTexture = (RenderTexture) img.mainTexture;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
