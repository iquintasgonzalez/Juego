﻿using UnityEngine;
using System.Collections;

public class Pausa : MonoBehaviour {
	public bool paused;
	// Use this for initialization
	void Start () {
		paused = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void pause ()
	{
			

			paused = !paused;

		Application.LoadLevel ("Menu");


		if (paused) {

			Time.timeScale = 0;



		} else if (!paused) {
			Time.timeScale = 1;
		}


			

	}
}
