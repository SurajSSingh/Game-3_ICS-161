using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCheck : MonoBehaviour {

	private bool is_active;
	[SerializeField]
	private string currentScene;
	public string showInScene;
	// Use this for initialization
	void Start () {
		this.gameObject.SetActive (true);
		this.is_active = true;
		this.currentScene = SceneManager.GetActiveScene().name;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.currentScene != this.showInScene && this.is_active == true) {
			this.gameObject.SetActive (false);
			this.is_active = false;
		}
		if (this.currentScene == this.showInScene && this.is_active == false) {
			this.gameObject.SetActive (true);
			this.is_active = true;
		}

	}

	void FixedUpdate (){
		this.currentScene = SceneManager.GetActiveScene().name;
	}
}
