using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour {

	public PlayerController player;
	public Text mainText;


	// Update is called once per frame
	void Update () {
		//Updates the text based on player info
		mainText.text = "Health: " + player.health;
	}
}
