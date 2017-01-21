﻿// Author: Zoodinger
// http://www.schemingdeveloper.com
// http://www.stopthegnomes.com

using UnityEngine;
using System.Collections;

namespace SpriteTile {
	public class SpriteTileDemo : MonoBehaviour {

		private int tilesX = 100;
		private int tilesY = 100;

		SpriteRenderer sr;

		// Use this for initialization
		void Start() {
			sr = GetComponent<SpriteRenderer>();
			UpdateTiles ();
		}

		void UpdateTiles() {
			var size = sr.sprite.bounds.size;
			//We need to resize the sprite according to how many tiles we want.
			//If we don't do this, all tiles will be squished into the original bounds of the sprite.
			//That might be intended in some cases, so this step is optional.
			transform.localScale = new Vector3(size.x * tilesX, size.y * tilesY, 1);

			//Set the x and y tile factors. The values don't have to be integers.
			sr.material.SetFloat("RepeatX", tilesX);
			sr.material.SetFloat("RepeatY", tilesY);
		}
			
	}
}