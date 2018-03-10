using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUI : MonoBehaviour {

    public GameObject Pause;
    public GameObject Dead;

	// Use this for initialization
	void Start () {
        GoGame();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
            GoPause();
    }

    private void GoGame()
    {
        Time.timeScale = 1;
        Pause.gameObject.SetActive(false);
        Dead.gameObject.SetActive(false);
    }

    private void GoPause()
    {
        Time.timeScale = 0;
        Pause.gameObject.SetActive(true);
        Dead.gameObject.SetActive(false);
    }

    private void GoDead()
    {
        Time.timeScale = 0;
        Pause.gameObject.SetActive(false);
        Dead.gameObject.SetActive(true);
    }

    public void MainButtonDown()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartButtonDown()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitButtondown()
    {
        Application.Quit();
    }

    public void BackButtonDown()
    {
        GoGame();
    }
}
