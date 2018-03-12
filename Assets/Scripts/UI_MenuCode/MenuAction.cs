using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAction : MonoBehaviour {

	public void ShowMenu (GameObject Menu)
	{
		Menu.SetActive (true);
	}

	public void CloseMenu (GameObject Menu)
	{
		if (Menu.activeInHierarchy == true) {
			Menu.SetActive (false);
		}
	}
}
