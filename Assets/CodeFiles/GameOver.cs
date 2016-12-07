using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	
	private Canvas gameOverInterface;

	private void Start () {
		gameOverInterface = (Canvas)GetComponent<Canvas>();
		Cursor.visible = true; 
		Destroy (GameObject.FindGameObjectWithTag ("Player"));
		Destroy (GameObject.FindGameObjectWithTag ("UI"));

	}

	public void OnStartAgainClick() {
		SceneManager.LoadScene ("MainMenu");
	}

	public void OnQuitClick(){
		Application.Quit ();
	}
}
