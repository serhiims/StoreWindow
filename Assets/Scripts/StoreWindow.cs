using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreWindow : MonoBehaviour {

	public StoreItems storeItems;
	public StoreItemView storeViewTemplate;
	public BasketController basket;
	void Start () {
		initStoreItems ();
		storeViewTemplate.transform.gameObject.SetActive (false);
	}

	private void initStoreItems() {
		for(int i = 0; i < storeItems.items.Length; i++) {
			var newItem = Instantiate (storeViewTemplate, transform, false);
			newItem.setData (storeItems.items[i]);
			newItem.StoreItemClickedEvent += onItemClicked;
		}
	}

	public void onItemClicked(StoreItemView item){		
		basket.addItem (item);
	}
}
