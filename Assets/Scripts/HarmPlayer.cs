using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmPlayer: MonoBehaviour {

	void OnTriggerStay2D (Collider2D coll){
		Debug.Log (coll.name);
		if (coll.gameObject.CompareTag("Player")) {
			coll.GetComponent<CarAttribute>().RemoveHealth(0.5f);
		}
	}
}
