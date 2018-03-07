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



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void RemoveHealth (float amount){
		this.healthCar -= amount;
		if(this.healthCar <= 0){
			SceneManager.LoadScene ("SingleGameWorld");
		}
	}

	public float getHealth (){
		return this.healthCar;
	}
}
