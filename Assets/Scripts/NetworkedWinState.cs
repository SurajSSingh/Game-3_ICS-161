using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetworkedWinState : NetworkBehaviour {

	void OnTriggerEnter2D (Collider2D coll){
		if (isServer) {
			if (coll.CompareTag ("State")) {
				RpcWin ();
			}
		}
	}

	[ClientRpc]
	void RpcWin (){
		Text infoText = null;
		Text[] allTexts = GameObject.FindObjectsOfType<Text> ();
		foreach (Text t in allTexts) {
			if (t.tag == "State") {
				infoText = t;
				break;
			}
		}
		if (infoText != null) {
			infoText.enabled = true;
			if (isLocalPlayer) {
				infoText.text = "You Win";
			} else {
				infoText.text = "You Lose";
			}
		}
	}
}
