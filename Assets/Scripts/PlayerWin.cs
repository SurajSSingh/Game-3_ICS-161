using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour {

	public CountDownTimer timer;
	public InGameUI UI;
	private bool has_won = false;

	void OnTriggerEnter2D (Collider2D coll){
		if(coll.CompareTag("AI_Player")){
			has_won = true;
			Invoke("Lose", 0.1f);
		}
		if (coll.CompareTag("Player")) {
			timer.TimerStop ();
			if (has_won == false) {
				has_won = true;
				Invoke("Win", 0.5f);
			}
		}
	}

	private void Win()
	{
		UI.GoWin();
	}

	public void Lose()
	{
		UI.GoDead();
	}
}
