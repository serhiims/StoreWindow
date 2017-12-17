using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;


public class IconView : MonoBehaviour {
	public Image image;
	public SpriteAtlas atlas;


	public void changeImage(string path){
		image.sprite = atlas.GetSprite(path);
	}

}
