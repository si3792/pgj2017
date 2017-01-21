using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour {

	public Sprite[] mSprites;
	public int mustEqSize;

	public void randomize()
	{
		int a = Random.Range (0, mustEqSize);
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = mSprites [a];
	}

	void Start() {
		randomize ();
	}

}
