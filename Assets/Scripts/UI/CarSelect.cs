using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelect : MonoBehaviour {

    public StartUI UI;
    public int number = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PushDown()
    {
        PlayerPrefs.SetInt("Car", number);
        UI.GoLobby();
    }
}
