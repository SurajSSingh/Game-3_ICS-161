using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
	public Image content;
	public CarAttribute player;


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () 
	{
		HandleHealthBar ();	
	}

	private void HandleHealthBar()
	{
		content.fillAmount = Map (player.getHealth (), 100.0f);
	}

	private float Map(float Current, float Max)
	{
		//Converts health from (0.0 to 100.0) into (0.0 to 1.0)
		float mValue = Current / Max; 
		if (mValue >= 1) {
			mValue = 1; 
		} 
		if (mValue <= 0) {
			mValue = 0;
		}
		return mValue﻿;
	}
}
