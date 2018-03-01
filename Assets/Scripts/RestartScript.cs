using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour {
	//public GameObject player;
	public string loadToLevel;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (loadToLevel); 
		}

		if (Input.GetKey("escape") || Input.GetKeyDown(KeyCode.Q))
			Application.Quit();
	}
}
