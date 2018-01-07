﻿using UnityEngine;

public class ItemPickup : Interactable {

	public override void Interact ()
	{
		base.Interact (); // execute default code

		PickUp();
	}


	void PickUp () {
		Debug.Log ("PickUp");
		Destroy(gameObject);
	}
}
