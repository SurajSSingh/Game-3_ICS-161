﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmPlayer: MonoBehaviour {


	void OnTriggerStay2D (Collider2D coll){
		if (coll.gameObject.CompareTag("Player") || coll.gameObject.CompareTag("AI_Player")) {
			if (this.CompareTag("Lava")) {
				coll.GetComponent<CarAttribute> ().RemoveHealth (2f);
			}else if(this.CompareTag("Spikes")){
				coll.GetComponent<CarAttribute> ().RemoveHealth (0.5f);
			}
		}
	}
}
