using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserInrerfaceController : MonoBehaviour {

	private Canvas UserInterface; 

	public Canvas userMenu ;
	public Canvas hudMenu ;
	//public Canvas timerLog;
	public Button startButton;
	//public Timer timer;
	//public Text countDownText ;


	// Use this for initialization
	void Start () {
		UserInterface = (Canvas)GetComponent<Canvas>();
	//	timer = new Timer (ref countDownText);
		userMenu = userMenu.GetComponent<Canvas> ();
 		
		startButton = startButton.GetComponent<Button> ();

		hudMenu = hudMenu.GetComponent<Canvas>();
		hudMenu.enabled = false;

		Time.timeScale = 0;
		 
	}
	
	// Update is called once per frame
	void Update () {
		if (hudMenu.enabled) {
		//	timer.CountDown ();
		}
	/*	if (Input.GetKeyUp (KeyCode.Escape)){
			userMenu.enabled = !userMenu.enabled;
			hudMenu.enabled = !hudMenu.enabled;

			Cursor.visible = userMenu.enabled;

		}*/
	}

	public void OnStartButtonClick() {
		userMenu.enabled = false;
		hudMenu.enabled = true;
		Time.timeScale = 1;

	
	}
}
