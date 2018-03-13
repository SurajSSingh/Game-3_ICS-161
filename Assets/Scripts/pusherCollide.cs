using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pusherCollide : MonoBehaviour {

	[SerializeField]
	private float launch_factor = 1.0f;

	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.CompareTag("Player")) {
			Vector2 launcher = this.GetComponent<BoxCollider2D>().attachedRigidbody.GetRelativeVector(Vector2.left);
			other.collider.attachedRigidbody.AddForce (launcher * launch_factor,ForceMode2D.Impulse);
		}
	}
}
