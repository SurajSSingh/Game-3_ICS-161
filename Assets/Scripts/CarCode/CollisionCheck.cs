using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag ("Lava")) {
			Debug.Log ("Lava");
		}

		if (other.gameObject.CompareTag("Player")) {
			Debug.Log ("Impact");
			this.GetComponent<CarAttribute> ().RemoveHealth(other.gameObject.GetComponent<CarController>().GetVelocity () 
				* this.GetComponent<CarAttribute> ().getDamageReduction ());
		}
	}
}
