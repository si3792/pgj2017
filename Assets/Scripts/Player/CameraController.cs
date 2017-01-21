using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/Player/Mini map")]
public class CameraController : MonoBehaviour {
    public GameObject renderPanel;
    Camera mapCamera;
    public Camera mainCamera;
    public RenderTexture tex;

	// Use this for initialization
	void Start () {
        mapCamera = GetComponent<Camera>();
        Camera.SetupCurrent(mainCamera);
        Image img = renderPanel.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
