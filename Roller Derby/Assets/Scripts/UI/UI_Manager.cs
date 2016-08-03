using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour {

	public GameObject pauseMenu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			if (Time.timeScale == 1) {
				pauseMenu.SetActive (true);
				Time.timeScale = 0;

			} 
			else 
			{
				Time.timeScale = 1;
				pauseMenu.SetActive (false);
			}
		}
	}

	public void Quit()
	{
		SceneManager.LoadScene ("Main Menu");
	}
}
