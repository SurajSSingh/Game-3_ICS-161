using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarVisualizer : MonoBehaviour {
	//This visualizes the car based on current attributes

	public Text healthText;
	public Text speedText;

	public Image contentHealth;
	public Image contentSpeed;

	[SerializeField]
	private bool is_AI;

	private Animator anim;
	private int hashHealth = Animator.StringToHash("Health");

	void Start (){
		if(this.GetComponentInParent<Grid>() != null){
			is_AI = true;
		}
		anim = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(is_AI == false){
			healthText.text = "Health: " + GetComponentInParent<CarAttribute>().getHealth().ToString ("F");
			speedText.text = GetComponentInParent<CarController>().GetVelocity().ToString ("F");
			HandleSpeedBar ();
			HandleHealthBar ();
		}
		anim.SetFloat (hashHealth,this.GetComponentInParent<CarAttribute>().getHealth());
		anim.speed = this.GetComponentInParent<CarController> ().GetVelocity ();
	}

	private void HandleSpeedBar()
	{
		contentSpeed.fillAmount = Map (this.GetComponentInParent<CarController> ().GetVelocity (), 20.0f);
	}


	private void HandleHealthBar()
	{
		contentHealth.fillAmount = Map (this.GetComponentInParent<CarAttribute> ().getHealth (), 100.0f);
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
