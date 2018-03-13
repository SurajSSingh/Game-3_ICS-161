using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag("Player")) {
			//When collided with another player
			this.GetComponent<CarAttribute> ().RemoveHealth(other.gameObject.GetComponent<CarController>().GetVelocity ()
				* other.gameObject.GetComponent<CarAttribute> ().getDamageReduction ());
		}
	}
}
