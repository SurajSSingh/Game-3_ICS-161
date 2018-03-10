using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		if(isLocalPlayer){
			GetComponent<CarController> ().enabled = true;
			GetComponent<CarAttribute> ().enabled = true;
			GetComponentInChildren<Canvas> ().enabled = true;
			Camera.main.transform.position = this.transform.position - this.transform.forward;
			Camera.main.transform.LookAt (this.transform.position);
			Camera.main.transform.parent = this.transform;
		}
	}
}
