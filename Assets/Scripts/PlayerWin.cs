using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour {

	public CountDownTimer timer;

	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			timer.TimerStop ();
		}
	}
}
