using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleSprites : MonoBehaviour {


	public int curSprite = 0;
	public Sprite[] mSprites;
	public int mustEqSize;
	public int waitFrames = 1;
	public int curWait = 0;


	void nextSprite() {
		curSprite++;
		if (curSprite >= mustEqSize)
			curSprite = 0;

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
