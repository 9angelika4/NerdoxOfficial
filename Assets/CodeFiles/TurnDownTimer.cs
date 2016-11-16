using UnityEngine;
using System.Collections;

public class TurnDownTimer : MonoBehaviour {


	public Canvas timerCanvas ;
	private Timer timerObject;


	// Use this for initialization
	void Start () {
		 
		timerObject = timerCanvas.GetComponent<Timer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!timerObject.removeTimer ()) {
			 
			timerCanvas.enabled = false;
		}
	}
}
