//Credit to Martin "quill18" Glaude

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
	//This class controls a car's movement

	[SerializeField]
	private float speedForce = 2f; //How fast the car moves
	[SerializeField]
	private float torqueForce = -200f; //How fast the car turns (- sign because turning is inverted)
	[SerializeField]
	private float driftFactorSticky = 0.7f; //How fast the sideways speed diminishes when car has traction 
	[SerializeField]
	private float driftFactorSlippy = 1; //How fast the sideways speed diminishes when slipping 
	[SerializeField]
	private float maxStickyVelocity = 3.5f;//Cut off point of traction
	//float minSlippyVelocity = 1.5f;

	// Use this for initialization
	void Start () {

	}

	void Update() {
	}

	// Update is called once per frame
	void FixedUpdate () {


		Rigidbody2D rb = GetComponent<Rigidbody2D>();

		float driftFactor = driftFactorSticky;
		if(RightVelocity().magnitude > maxStickyVelocity) {
			driftFactor = driftFactorSlippy;
		}

		rb.velocity = ForwardVelocity() + RightVelocity()*driftFactor;

		if(Input.GetButton("Accelerate")) {
			rb.AddForce( transform.up * speedForce );

		}
		if(Input.GetButton("Brakes")) {
			rb.AddForce( transform.up * -speedForce/2f );

		}

		// If you are using positional wheels in your physics, then you probably
		// instead of adding angular momentum or torque, you'll instead want
		// to add left/right Force at the position of the two front tire/types
		// proportional to your current forward speed (you are converting some
		// forward speed into sideway force)
		float tf = Mathf.Lerp(0, torqueForce, rb.velocity.magnitude / 2);
		rb.angularVelocity = Input.GetAxis("Horizontal") * tf;



	}

	Vector2 ForwardVelocity() {
		return transform.up * Vector2.Dot( GetComponent<Rigidbody2D>().velocity, transform.up );
	}

	Vector2 RightVelocity() {
		return transform.right * Vector2.Dot( GetComponent<Rigidbody2D>().velocity, transform.right );
	}
	public float GetVelocity() {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		return 0.5f * rb.mass * Mathf.Pow(rb.velocity.magnitude, 2);
	}



}
