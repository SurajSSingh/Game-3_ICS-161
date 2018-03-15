using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointerChange : MonoBehaviour {

	[SerializeField]
	private int trackNumber = 0;

	[SerializeField]
	private List<Transform> nodes = new List<Transform>();

	private int current = 0;
	private bool active = false;

	// Use this for initialization
	void Start () {
		current = 0;
		active = false;

//		switch{
//
//		GameObject track = ;
//		}

		Transform[] pathNodes = GetComponentsInChildren<Transform>();
		nodes = new List<Transform>();

		for (int i = 0; i < pathNodes.Length; ++i){
			if(pathNodes[i] != this.transform){
				nodes.Add (pathNodes[i]);
			}
		}
		if(nodes.Count > 0){
			this.transform.position = nodes [current].position;
			active = true;
		}
	}

	void OnTriggerEnter2D (Collider2D coll){
		if(active == true && coll.CompareTag("AI_Player") ){//&& current < nodes.Count){
			++current;
			this.transform.position = nodes [current].position;
			active = true;
		}
	}

}
