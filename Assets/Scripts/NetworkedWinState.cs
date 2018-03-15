using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetworkedWinState : NetworkBehaviour {

	InGameUI UI = new InGameUI();
	private Text infoText;
	private bool has_won = false;

	void OnTriggerEnter2D (Collider2D coll){
		Debug.Log (has_won);
		if (isServer) {
			if (coll.CompareTag ("State")) {
				RpcWin ();
				has_won = true;
			}
		}
	}

	[ClientRpc]
	void RpcWin (){
		Text[] infoArray = GameObject.FindObjectsOfType<Text> ();
		foreach (Text t in infoArray){
			if (t.CompareTag ("Screen")) {
				infoText = t;
			}
		}
		if (infoText != null && has_won == false) {
			infoText.color = Color.cyan;
			if (isLocalPlayer) {
				infoText.text = "You Win";
				Invoke("Win", 0.1f);
			} else {
				infoText.text = "You Lose";
				Invoke("Lose", 0.1f);
			}
			has_won = true;
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
