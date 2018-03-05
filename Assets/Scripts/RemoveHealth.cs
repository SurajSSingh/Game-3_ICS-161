using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHealth : MonoBehaviour {

	public CarAttribute carAttr;

	void OnTriggerStay2D (Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			carAttr.RemoveHealth (1.0f);
		}
	}
}
