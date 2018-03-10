using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetworkedWinState : NetworkBehaviour {

	private Text infoText;

	void OnTriggerEnter2D (Collider2D coll){
		if (isServer) {
			if (coll.CompareTag ("State")) {
				RpcWin ();

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
		//Debug.Log (infoText);
		if (infoText != null) {
			infoText.color = Color.cyan;
			if (isLocalPlayer) {
				infoText.text = "You Win";
			} else {
				infoText.text = "You Lose";
			}
		}
	}
}
