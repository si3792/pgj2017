using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleSprites : MonoBehaviour {


	public int curSprite = 0;
	public Sprite[] mSprites;
	public int mustEqSize;
	public int waitFrames = 1;
	public int curWait = 0;
	public bool destroyOnEnd = false;

	void nextSprite() {
		curSprite++;
		if (curSprite >= mustEqSize) {
			if (destroyOnEnd) {
				this.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			Destroy (this.gameObject);
			}
		else {
			curSprite = 0;

		
		}
		}
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = mSprites [curSprite];
	}

	void FixedUpdate() {

		curWait++;
		if (curWait > waitFrames) {
			nextSprite ();
			curWait = 0;
		}
	}
}
