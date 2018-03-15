﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorCollide : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("AI_Player")) {
			other.gameObject.GetComponent<CarAttribute> ().RemoveHealth (1f);
		}
	}
	void OnCollisionStay2D (Collision2D other){
		if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("AI_Player")) {
			other.gameObject.GetComponent<CarAttribute> ().RemoveHealth (1f);
		}
	}
}
