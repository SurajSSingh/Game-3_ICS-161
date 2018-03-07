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
	private float chash_threshold = 0.55f;

	private float prev_velocity = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate (){
		//Check if there is a crash (or generally a large change in acceleration) and does some amount of damaage
		float impulse = Mathf.Abs(this.GetComponentInParent<CarController> ().GetVelocity () - prev_velocity);
		if (impulse > chash_threshold) {
			this.healthCar-= impulse;
		}
		prev_velocity = this.GetComponentInParent<CarController> ().GetVelocity ();
	}

	public void RemoveHealth (float amount){
		this.healthCar -= amount;
		if(this.healthCar <= 0){
			--lives;
			SceneManager.LoadScene ("SingleGameWorld");
		}
	}

	public float getHealth (){
		return this.healthCar;
	}
}
