using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmPlayer: MonoBehaviour {

	void OnTriggerStay2D (Collider2D coll){
		if (coll.gameObject.CompareTag("Player") || coll.gameObject.CompareTag("Player_Net")) {
			coll.GetComponent<CarAttribute>().RemoveHealth(1.0f);
		}
	}
}
