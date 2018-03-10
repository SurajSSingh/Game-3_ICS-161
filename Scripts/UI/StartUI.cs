using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour {

    public GameObject Main;
    public GameObject PlayerMode;

	// Use this for initialization
	void Start () {
        GoMain();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartButtonDown()
    {
        GoPlayerMode();
    }

    public void QuitButtonDown()
    {
        Application.Quit();
    }

    public void SingleButtonDown()
    {
        SceneManager.LoadScene(1);
    }

    public void MultiButtonDown()
    {
        SceneManager.LoadScene(2);
    }

    public void BackButtonDown()
    {
        GoMain();
    }

    private void GoMain()
    {
        Main.gameObject.SetActive(true);
        PlayerMode.gameObject.SetActive(false);
    }

    private void GoPlayerMode()
    {
        Main.gameObject.SetActive(false);
        PlayerMode.gameObject.SetActive(true);
    }
}
