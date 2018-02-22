using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

	public GameObject gameOverUI;

	// Restart a game
	public void Restart() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		Time.timeScale = 1;
	}

	// Stop a game
	public void GameStop() {
		Time.timeScale = 0;
		gameOverUI.SetActive (true);
	}
}
