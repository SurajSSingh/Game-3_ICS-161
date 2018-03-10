using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour {
	float TimeGiven = 0.0f;
	public Text timerText;
	public bool gameEnded;

	
	// Update is called once per frame
	void Update () {
		//Takes the time passed and formats the text to display current time (up to 2 decimal places)

		if (!gameEnded) {
			TimeGiven += Time.deltaTime;

			string seconds = (TimeGiven).ToString ("F");
			timerText.text = "Time: " + seconds;
		}
	}

	public void TimerStop(){
		gameEnded = true;
	}
}
