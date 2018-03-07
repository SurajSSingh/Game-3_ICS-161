using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHealth : MonoBehaviour {

	void OnTriggerStay2D (Collider2D coll){
		if (coll.gameObject.CompareTag("Player")) {
			coll.GetComponentInParent<CarAttribute>().RemoveHealth(1.0f);
		}
	}
}
