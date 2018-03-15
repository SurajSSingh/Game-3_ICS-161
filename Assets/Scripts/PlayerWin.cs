using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour {

	public CountDownTimer timer;
	private bool has_won = false;

	void OnTriggerEnter2D (Collider2D coll){
		if(coll.CompareTag("AI_Player")){
			has_won = true;
		}
		if (coll.CompareTag("Player")) {
			timer.TimerStop ();
			if (has_won = false) {
//				UI.GoWin();
				has_won = true;
			}
		}
	}
}
