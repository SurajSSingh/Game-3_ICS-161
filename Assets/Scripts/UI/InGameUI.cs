using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUI : MonoBehaviour {

	public GameObject Pause;
	public GameObject Dead;
	public GameObject Win;
	public GameObject Help;
	public CarAttribute Player;

	public GameObject Track1;
	public GameObject Track2;
	public GameObject Car1;
	public GameObject Car2;
	public GameObject Car3;

	private bool check;

	// Use this for initialization
	void Start () {
		GoGame();
		check = false;
		TrackSelect();
		CarSelect();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape) && !check)
			GoPause();
		if (CheckDeath())
			GoDead();
	}

	// Using this to select the track we play
	private void TrackSelect()
	{
		int track = PlayerPrefs.GetInt("Track");
		if(track == 1)
		{
			Track1.gameObject.SetActive(true);
			Track2.gameObject.SetActive(false);
		}
		else if(track == 2)
		{
			Track2.gameObject.SetActive(true);
			Track1.gameObject.SetActive(false);
		}

	}

	private void CarSelect()
	{
		int car = PlayerPrefs.GetInt("Car");
		if (car == 1)
		{
			Car1.gameObject.SetActive(true);
			Car2.gameObject.SetActive(false);
			Car3.gameObject.SetActive(false);
		}
		else if (car == 2)
		{
			Car2.gameObject.SetActive(true);
			Car1.gameObject.SetActive(false);
			Car3.gameObject.SetActive(false);
		}
		else if(car == 3)
		{
			Car1.gameObject.SetActive(false);
			Car2.gameObject.SetActive(false);
			Car3.gameObject.SetActive(true);
		}

	}

	private bool CheckDeath()
	{
		//Check death or lose
		if ((Player.getHealth() <= 0) && !check)
			return true;
		else return false;
	}

	private void GoGame()
	{
		Time.timeScale = 1;
		Pause.gameObject.SetActive(false);
		Dead.gameObject.SetActive(false);
		Win.gameObject.SetActive(false);
		Help.gameObject.SetActive(false);
	}

	private void GoPause()
	{
		if (PlayerPrefs.GetInt("Mode") == 1)
			Time.timeScale = 0;
		Pause.gameObject.SetActive(true);
		Dead.gameObject.SetActive(false);
		Win.gameObject.SetActive(false);
		Help.gameObject.SetActive(false);
	}

	public void GoDead()
	{
		if (PlayerPrefs.GetInt("Mode") == 1)
			Time.timeScale = 0;
		check = true;
		Pause.gameObject.SetActive(false);
		Dead.gameObject.SetActive(true);
		Win.gameObject.SetActive(false);
		Help.gameObject.SetActive(false);
	}

	public void GoWin()
	{
		if (PlayerPrefs.GetInt("Mode") == 1)
			Time.timeScale = 0;
		check = true;
		Pause.gameObject.SetActive(false);
		Dead.gameObject.SetActive(false);
		Win.gameObject.SetActive(true);
		Help.gameObject.SetActive(false);
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

	public void HelpButtonDown()
	{
		Pause.gameObject.SetActive(false);
		Dead.gameObject.SetActive(false);
		Win.gameObject.SetActive(false);
		Help.gameObject.SetActive(true);
	}

	public void GoBackDown()
	{
		GoPause();
	}
}
