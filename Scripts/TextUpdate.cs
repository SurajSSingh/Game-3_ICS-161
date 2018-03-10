using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour {

	public CarAttribute carAttr;
	public Text mainText;


	// Update is called once per frame
	void Update () {
		//Updates the text based on player info
		mainText.text = "Health: " + carAttr.getHealth ().ToString ();
	}
}
