using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserInrerfaceController : MonoBehaviour {


	private Canvas resumeMenu ;
	public Canvas hudMenu ;
	public Canvas quitQuestion ;
	public Button playButton;
	private bool isTimePass = true;

	public bool IsTimePass () {
		return isTimePass;
	}

	void Start () {
		resumeMenu = (Canvas)GetComponent<Canvas>();
		hudMenu = hudMenu.GetComponent<Canvas> ();
		quitQuestion = quitQuestion.GetComponent<Canvas> ();
		playButton = playButton.GetComponent<Button> ();	
		resumeMenu.enabled = true;
		hudMenu.enabled = false;
		isTimePass = !resumeMenu.enabled;
		quitQuestion.enabled = false;
		Cursor.visible = resumeMenu.enabled;
		Cursor.lockState = CursorLockMode.Confined;
	}

	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) {
			
			resumeMenu.enabled = ! resumeMenu.enabled;
			Debug.Log ("is time pass  " +   isTimePass);
			isTimePass = !resumeMenu.enabled;
			hudMenu.enabled = !resumeMenu.enabled;
			Cursor.visible = resumeMenu.enabled;
			if (resumeMenu.enabled) {
				Cursor.lockState = CursorLockMode.Confined;
				Cursor.visible = true;
				Time.timeScale = 0;
			} else {
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				Time.timeScale = 1;
			}
		}
	}

	public void OnExitButtonClick () {
		resumeMenu.enabled = false;
		quitQuestion.enabled = true;
		hudMenu.enabled = false;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;

	} 
	public void OnPlayGameButtonClick() {
		isTimePass = true;
		resumeMenu.enabled = false;
		quitQuestion.enabled = false;
		hudMenu.enabled = true;
		Time.timeScale = 1;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Confined;
		playButton.enabled = true;

	}

	public void YesQuitButton (){
		Application.Quit();

	}
 
}
