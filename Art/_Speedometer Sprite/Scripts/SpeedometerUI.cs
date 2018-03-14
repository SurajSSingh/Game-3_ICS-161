// ---------------------------------------
// A simple code to show a speedometer
// on your screen, change the var SPEED
// to see needles move. (C)2017 Creepy Cat
// ---------------------------------------
using UnityEngine;
using System.Collections;

public class SpeedometerUI : MonoBehaviour {
	public Texture2D backTex;
	public Texture2D dialTex;
	public Texture2D needleTex;
	public Texture2D needleCache;
	public float needleSizeRatio=3;
	public Vector2 counterPos;
	public Vector2 counterSize = new Vector2(200,200);
	public float topSpeed=100;
	public float stopAngle=-211;
	public float topSpeedAngle=31;
	public float speed=0;
    public CarController car;

	void Update(){
		// Yeah top AAA demo :)
		speed = car.GetVelocity()*5;
	}

	void  OnGUI (){
		// Draw title
		GUI.Box(new Rect(10, 10, Screen.width-20, 25), "MOVE THE MOUSE FROM LEFT TO RIGHT AND LOOK THE NEEDLES");


		// Draw the back
		GUI.DrawTexture( new Rect(counterPos.x, counterPos.y, counterSize.x, counterSize.y), backTex);

		// Draw the counter
		GUI.DrawTexture( new Rect(counterPos.x+15, counterPos.y+15, counterSize.x-30, counterSize.y-30), dialTex);

		// Calculate center
		Vector2 centre= new Vector2(counterPos.x + (counterSize.x / 2), counterPos.y + (counterSize.y / 2) );
		Matrix4x4 savedMatrix= GUI.matrix;

		// Calculate angle
		float speedFraction= speed / topSpeed;
		float needleAngle= Mathf.Lerp(stopAngle, topSpeedAngle, speedFraction);

		GUIUtility.RotateAroundPivot(needleAngle, centre);

		// Draw the needle
		GUI.DrawTexture( new Rect(centre.x+5, (centre.y+10) - needleTex.height / 2, needleTex.width/needleSizeRatio, needleTex.height/needleSizeRatio), needleTex);
		GUI.matrix = savedMatrix;

		// Draw the needle cache
		GUI.DrawTexture( new Rect(centre.x-30, centre.y-30, 60, 60), needleCache);
	}
}