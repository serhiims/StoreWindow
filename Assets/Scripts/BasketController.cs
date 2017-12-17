using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour {

	public void addItem(StoreItemView item){
		if (item == null) {
			return;
		}

		var newItem = Instantiate (item, transform, false);
		newItem.StoreItemClickedEvent += onItemClicked;
	}

	public void onItemClicked(StoreItemView item){
		item.StoreItemClickedEvent -= onItemClicked;
		Destroy (item.gameObject);
	}
}
