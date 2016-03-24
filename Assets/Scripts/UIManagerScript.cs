using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour {

	public void StartGame() {
		SceneManager.LoadScene("RocketMouse");
	}
}
