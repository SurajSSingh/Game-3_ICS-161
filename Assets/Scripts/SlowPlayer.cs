using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowPlayer : MonoBehaviour {

	public float change_drag;

	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.CompareTag("Player") || coll.gameObject.CompareTag("AI_Player")) {
			coll.attachedRigidbody.drag *= change_drag;
		}
	}

	void OnTriggerExit2D (Collider2D coll){
		if (coll.gameObject.CompareTag("Player") || coll.gameObject.CompareTag("AI_Player")) {
			coll.attachedRigidbody.drag /= change_drag;
		}
	}
}
