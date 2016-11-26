using UnityEngine;
using System.Collections;

public class TurnDownTextPanel : MonoBehaviour {

	public Canvas dialogCanvas;
	private void Start () {
		dialogCanvas.enabled = false;
	}
	public void turnDownPanel () {
		dialogCanvas.enabled = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Confined;
		Time.timeScale = 1;
	}

	public void turnOnPanel () {
		Time.timeScale = 0;
		dialogCanvas.enabled = true;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Locked;
	 
	}
}
