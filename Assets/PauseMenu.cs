using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public string mainMenu;

	public bool isPaused;

	public GameObject pauseMenuCanvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (isPaused) {
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0;
		} else {
			pauseMenuCanvas.SetActive (false);
			Time.timeScale = 1;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			isPaused = !isPaused;
		}
	
	}

	public void Resume(){
		
		isPaused = false;
}

	public void Quit(){
		Application.LoadLevel (mainMenu);
	}
}