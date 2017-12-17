using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoreItemView : MonoBehaviour {
	protected string id;
	public TextMeshProUGUI countTF;
	public TextMeshProUGUI priceTF;
	public TextMeshProUGUI descriptionTF;
	public IconView icon;

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
}
