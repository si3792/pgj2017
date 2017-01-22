﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour {

	public Sprite[] mSprites;
	public int mustEqSize;
	public int chosenSprite = 0;

	public void randomize()
	{
		chosenSprite = Random.Range (0, mustEqSize);
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = mSprites [chosenSprite];
	}

	void Start() {
		randomize ();
	}

}
