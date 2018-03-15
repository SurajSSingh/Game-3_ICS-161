using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarAttribute : MonoBehaviour {
	//This holds the attributes of a specific car

	[SerializeField]
	private float healthCar = 100f; //How much health the car has
	[SerializeField]
	private float speedMultiplier = 1f; //How fast the car can moves (multiplier: speed * this = true speed)
	[SerializeField]
	private float damageResistence = 1f; //How much damage the car is resistent to (multiplier: damage * this = true damage)
	[SerializeField]
	private string itemOne = ""; //Item 1 of the car
	[SerializeField]
	private string itemTwo = ""; //Item 2 of the car
	[SerializeField]
	private int lives = 3;
	[SerializeField]
	private float crash_threshold = 1.5f;
	[SerializeField]
	private float crash_multiplier = 0.5f;

	[SerializeField]
	private bool is_AI = false;

	private float prev_velocity = 0.0f;

	public string sceneLoad;
	private GameObject resetPosition;

	// Use this for initialization
	void Start () {
		crash_threshold = 1.5f;
		if (this.GetComponent<Grid> () != null) {
			is_AI = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate (){
		//Check if there is a crash (or generally a large change in acceleration - based on current minus previous velocity) and does some amount of damaage
		if (is_AI == false) {
			float current_velocity = this.GetComponentInParent<CarController> ().GetVelocity ();
			float impulse = Mathf.Abs (current_velocity - prev_velocity);
			if (impulse > crash_threshold && current_velocity != 0) {
				RemoveHealth (impulse * crash_multiplier);
			}
			prev_velocity = current_velocity;
		}
	}

	public void RemoveHealth (float amount){
		this.healthCar -= amount;
		if(this.healthCar <= 0){
			--lives;
			resetPosition = GameObject.FindGameObjectWithTag ("Respawn");
			if (sceneLoad == "" && resetPosition != null) { 
				this.GetComponent<CarController> ().killVelocity ();
				this.transform.position = resetPosition.transform.position;
				this.healthCar = 100f;
			} else {
				if (is_AI == false) {
					SceneManager.LoadScene (sceneLoad);
				}
			}
		}
	}

	public float getHealth (){
		return this.healthCar;
	}
	public float getDamageReduction (){
		return this.damageResistence;
	}
}
