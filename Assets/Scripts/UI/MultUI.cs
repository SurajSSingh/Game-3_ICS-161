using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultUI : MonoBehaviour {

    public GameObject Pause;
    public GameObject Dead;
    public GameObject Win;
    public CarAttribute Player;


    private bool check;

    // Use this for initialization
    void Start()
    {
        GoGame();
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && !check)
            GoPause();
        if (CheckDeath())
            GoDead();
    }

    private bool CheckDeath()
    {
        if (Player.getHealth() == 0 && !check)
            return true;
        else return false;
    }

    private void GoGame()
    {
        Time.timeScale = 1;
        Pause.gameObject.SetActive(false);
        Dead.gameObject.SetActive(false);
        Win.gameObject.SetActive(false);
    }

    private void GoPause()
    {
        if (PlayerPrefs.GetInt("Mode") == 1)
            Time.timeScale = 0;
        Pause.gameObject.SetActive(true);
        Dead.gameObject.SetActive(false);
        Win.gameObject.SetActive(false);
    }

    private void GoDead()
    {
        if (PlayerPrefs.GetInt("Mode") == 1)
            Time.timeScale = 0;
        check = true;
        Pause.gameObject.SetActive(false);
        Dead.gameObject.SetActive(true);
        Win.gameObject.SetActive(false);
    }

    public void GoWin()
    {
        if (PlayerPrefs.GetInt("Mode") == 1)
            Time.timeScale = 0;
        check = true;
        Pause.gameObject.SetActive(false);
        Dead.gameObject.SetActive(false);
        Win.gameObject.SetActive(true);
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
    }

    public void GoBackDown()
    {
        GoPause();
    }
}
