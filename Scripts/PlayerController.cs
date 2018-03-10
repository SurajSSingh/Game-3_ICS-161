using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float speed;             //Floating point variable to store the player's movement speed.
	public float health = 100.0f; 			//Floating point variable to store the player's current health.
	public float loss_value;		//Floating point variable to store the loss value for health when off track.

	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();
	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{
		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = Input.GetAxis ("Horizontal");

		//Store the current vertical input in the float moveVertical.
		float moveVertical = Input.GetAxis ("Vertical");

		//Use the two store floats to create a new Vector2 variable movement.
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);


		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		rb2d.AddForce (movement * speed);
	}

	public void LoseHealth (){
		//For triggers 
		//While player is in the trigger, player loses health 
		health -= loss_value;
		if(health <= 0){
			SceneManager.LoadScene ("GameWorld");
		}
	}
}