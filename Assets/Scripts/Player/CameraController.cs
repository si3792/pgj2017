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
        tex.width = Screen.width / 10;
        tex.height = Screen.height / 10;
        Image img = renderPanel.GetComponent<Image>();
        mapCamera.targetTexture = (RenderTexture) img.mainTexture;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
