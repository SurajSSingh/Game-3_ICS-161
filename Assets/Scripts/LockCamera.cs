using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LockCamera : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		//To be deleted
//		if (isLocalPlayer) {
//			Camera.main.transform.position = this.transform.position - this.transform.forward;
//			Camera.main.transform.LookAt (this.transform.position);
//			Camera.main.transform.parent = this.transform;
//		}
	}

	void Update (){
		if (isLocalPlayer) {
			Camera.main.transform.eulerAngles = new Vector3 (0f, 0f, 0f);
		}
	}
}
