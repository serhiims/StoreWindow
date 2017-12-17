using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class StoreItemView : MonoBehaviour {
	public string id;
	public TextMeshProUGUI countTF;
	public TextMeshProUGUI priceTF;
	public TextMeshProUGUI descriptionTF;
	public IconView icon;
	public Button button;
	public event Action<StoreItemView> StoreItemClickedEvent;

	void Start(){
		button.onClick.AddListener (OnMouseDown);
	}

	public void setData(StoreItemData item){
		if(item == null){
			return;
		}
		id = item.itemId;
		countTF.text = item.count.ToString ();
		priceTF.text = item.price.ToString("C");
		descriptionTF.text = item.description;
		icon.changeImage (item.iconPath);
	}

	public void OnMouseDown() {
		Debug.Log (id);
	    if(StoreItemClickedEvent != null)
		{
			StoreItemClickedEvent(this);
		}
	}
}
