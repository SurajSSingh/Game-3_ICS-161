﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour {

	public GameObject Main;
	public GameObject PlayerMode;
	public GameObject Credit;
	public GameObject Lobby;
	public GameObject CarSelect;
	public GameObject TrackSelect;
	public GameObject Help;

	private int SingleID = 1;
	private int MultiID = 2;

	// Use this for initialization
	void Start () {
		GoMain();
		PlayerPrefs.SetInt("Car", 1);
		PlayerPrefs.SetInt("Track", 1);
	}

	// Update is called once per frame
	void Update () {

	}

	public void StartButtonDown()
	{
		Main.gameObject.SetActive(false);
		PlayerMode.gameObject.SetActive(true);
		Credit.gameObject.SetActive(false);
		Lobby.gameObject.SetActive(false);
		CarSelect.gameObject.SetActive(false);
		TrackSelect.gameObject.SetActive(false);
		Help.gameObject.SetActive(false);
	}

	public void QuitButtonDown()
	{
		Application.Quit();
	}

	public void SingleButtonDown()
	{
		Main.gameObject.SetActive(false);
		PlayerMode.gameObject.SetActive(false);
		Credit.gameObject.SetActive(false);
		Lobby.gameObject.SetActive(true);
		CarSelect.gameObject.SetActive(false);
		TrackSelect.gameObject.SetActive(false);
		Help.gameObject.SetActive(false);
	}

	public void MultiButtonDown()
	{
		PlayerPrefs.SetInt("Mode", 2);
		SceneManager.LoadScene(MultiID);
	}

	public void BackButtonDown()
	{
		GoMain();
	}

	public void CreditButtonDown()
	{
		Credit.gameObject.SetActive(true);
		Main.gameObject.SetActive(false);
		PlayerMode.gameObject.SetActive(false);
		Lobby.gameObject.SetActive(false);
		CarSelect.gameObject.SetActive(false);
		TrackSelect.gameObject.SetActive(false);
		Help.gameObject.SetActive(false);
	}

	public void CarButtonDown()
	{
		Main.gameObject.SetActive(false);
		PlayerMode.gameObject.SetActive(false);
		Credit.gameObject.SetActive(false);
		Lobby.gameObject.SetActive(false);
		CarSelect.gameObject.SetActive(true);
		TrackSelect.gameObject.SetActive(false);
		Help.gameObject.SetActive(false);
	}

	public void TrackButtonDown()
	{
		Main.gameObject.SetActive(false);
		PlayerMode.gameObject.SetActive(false);
		Credit.gameObject.SetActive(false);
		Lobby.gameObject.SetActive(false);
		CarSelect.gameObject.SetActive(false);
		TrackSelect.gameObject.SetActive(true);
		Help.gameObject.SetActive(false);
	}

	public void PlayButtonDown()
	{
		PlayerPrefs.SetInt("Mode", 1);
		SceneManager.LoadScene(SingleID);
	}

	public void HelpButtonDown()
	{
		Main.gameObject.SetActive(false);
		PlayerMode.gameObject.SetActive(false);
		Credit.gameObject.SetActive(false);
		Lobby.gameObject.SetActive(false);
		CarSelect.gameObject.SetActive(false);
		TrackSelect.gameObject.SetActive(false);
		Help.gameObject.SetActive(true);
	}

	private void GoMain()
	{
		Main.gameObject.SetActive(true);
		PlayerMode.gameObject.SetActive(false);
		Credit.gameObject.SetActive(false);
		Lobby.gameObject.SetActive(false);
		CarSelect.gameObject.SetActive(false);
		TrackSelect.gameObject.SetActive(false);
		Help.gameObject.SetActive(false);
	}

	public void GoLobby()
	{
		Main.gameObject.SetActive(false);
		PlayerMode.gameObject.SetActive(false);
		Credit.gameObject.SetActive(false);
		Lobby.gameObject.SetActive(true);
		CarSelect.gameObject.SetActive(false);
		TrackSelect.gameObject.SetActive(false);
		Help.gameObject.SetActive(false);
	}
}
