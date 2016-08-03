using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HighScore_Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Quit()
	{
		SceneManager.LoadScene ("Highscores");
	}
}
