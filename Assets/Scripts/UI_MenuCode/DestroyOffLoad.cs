using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffLoad : MonoBehaviour {
	//Destroys game objects when called

	public void DestroyUndestroyed (GameObject go)
	{
		Destroy (go);
	}
}
