using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour {

	public Animator startButton;
	public Animator settingsButton;

	public void StartGame() {
		SceneManager.LoadScene("RocketMouse");
	}

	public void OpenSettings() {
		startButton.SetBool("isHidden", true);
		settingsButton.SetBool("isHidden", true);
	}
}
