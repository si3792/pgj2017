using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigureGlow : MonoBehaviour {

	public Sprite[] mSprites;
	public int mustEqSize;
	public int chosenSprite;

	void FixedUpdate() {

		chosenSprite = transform.parent.GetComponent<RandomSprite>().chosenSprite;
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = mSprites [chosenSprite];

	}
}
