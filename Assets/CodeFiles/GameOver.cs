using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	private Canvas gameOverInterface;

	public Button startAgain;
	public Button quit;

	// Use this for initialization
	void Start () {
		gameOverInterface = (Canvas)GetComponent<Canvas>();

		startAgain = startAgain.GetComponent<Button> ();
		quit = quit.GetComponent<Button> ();
		Cursor.visible = true; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnStartAgainClick() {
		SceneManager.LoadScene ("MainScene");
	}

	public void OnQuitClick(){
		Application.Quit ();
	}
}
