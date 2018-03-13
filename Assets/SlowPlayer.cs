using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowPlayer : MonoBehaviour {

	[SerializeField]
	private float stop_threshold = 0.5f;

	void OnTriggerStay2D (Collider2D coll){
		if (coll.gameObject.CompareTag("Player") && coll.gameObject.GetComponent<CarController>().GetVelocity() > stop_threshold) {
			coll.attachedRigidbody.AddRelativeForce(Vector2.down);
		}
	}
}
