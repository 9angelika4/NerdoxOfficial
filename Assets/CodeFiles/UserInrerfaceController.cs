using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserInrerfaceController : MonoBehaviour {


	public Canvas resumeMenu ;
	public Canvas hudMenu ;
	public Canvas quitQuestion ;
	private bool isGameRunning;
	private bool isQuitMenuEnabled;
	 
	public Button playGame;
	public Button exitGame;
	public Button yesLeave ;
	public Button dontLeave;

	private bool isTimePass = true;

	public bool IsTimePass () {
		return isTimePass;
	}

	private void Start () {
		Debug.Log ("show me ");
		Initialize ();
		RunGame ();
		isQuitMenuEnabled = false;
	}

	void Update () {
 
		if (Input.GetKeyUp (KeyCode.Escape)) {
			VisibleCursor ();
			if (isQuitMenuEnabled) {
				VisibleCursor ();
			} else if (isGameRunning) {
				resumeMenu.enabled = false;
				ResumeMenuRun ();
			} else {
				RunGame ();
			}
		}
	}

	public void OnExitButtonClick () {
		isQuitMenuEnabled = true;
		ResumeMenuDisable ();
		QuitQuestionEnable ();
		HudMenuEnable ();
		VisibleCursor ();
		isGameRunning = false;

	} 
	public void OnPlayGameButtonClick() {
		Debug.Log ("GAME MOTHER");
		isQuitMenuEnabled = false;
		RunGame ();
	}


	public void YesQuitButton (){
		VisibleCursor ();
		Application.Quit();
	}

	public void NoQuitButton(){
		isQuitMenuEnabled = false;
		VisibleCursor ();
		ResumeMenuDisable ();
		QuitQuestionDisable ();
		InvisibleCursor ();
		TurnOnTime ();
	}

 
	private void Initialize(){
		
		hudMenu	   = hudMenu.GetComponent<Canvas> ();
		quitQuestion = quitQuestion.GetComponent<Canvas> ();
		resumeMenu = resumeMenu.GetComponent<Canvas>();
	}
	private void RunGame(){
		isQuitMenuEnabled = false;
		ResumeMenuDisable ();
		QuitQuestionDisable ();
		HudMenuEnable ();
		TurnOnTime ();
		InvisibleCursor ();
		isGameRunning = true;
	}
	public  void ResumeMenuRun () {
		isQuitMenuEnabled = false;
		TurnDownTime ();
		ResumeMenuEnable ();
		QuitQuestionDisable ();
		VisibleCursor ();
		isGameRunning = false;
	}
		
	private void ResumeMenuIEnabled(){
		quitQuestion.enabled = false;
	}
	private void InvisibleCursor () {
		Cursor.visible = false;
	}
	private void VisibleCursor () {
		Cursor.visible = true;
	}
	private void TurnDownTime () {
		Time.timeScale = 0;
	}
	private void TurnOnTime(){
		Time.timeScale = 1;
	}

	private void ResumeMenuEnable (){
		resumeMenu.enabled = true;
		playGame.enabled = true;
		exitGame.enabled = true;
	}
	private void ResumeMenuDisable(){
		resumeMenu.enabled = false;
		playGame.enabled = false;
		exitGame.enabled = false;
	}
	private void HudMenuEnable () {
		hudMenu.enabled = true;

	}
	private void HudMenuDisable(){
		hudMenu.enabled = false;
	}
	private void QuitQuestionEnable(){
		quitQuestion.enabled = true;
		yesLeave.enabled = true;
		dontLeave.enabled = true;

	}
	private void QuitQuestionDisable(){
		quitQuestion.enabled = false;
		yesLeave.enabled = false;
		dontLeave.enabled = false;
	}


}
