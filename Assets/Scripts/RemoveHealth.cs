using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHealth : MonoBehaviour {

	public PlayerController player;

	void OnTriggerStay2D (Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			player.LoseHealth ();
		}
	}
}
