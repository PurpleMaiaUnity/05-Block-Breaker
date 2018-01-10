﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Brick.breakableCount = 0;
		//Application.LoadLevel (name);
		SceneManager.LoadScene (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
	
	public void LoadNextLevel() {
		Brick.breakableCount = 0;
		//Application.LoadLevel(Application.loadedLevel + 1); //outdated function
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	public void BrickDestoyed() {
		if (Brick.breakableCount <= 0) {
			LoadNextLevel();
		}
	}
}
