using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour {

	private Canvas timerInterface; 
	private float timeLeft = 10f;
	public Timer timer;
	public Text countDownText ;
	public GameObject exitTrigger; 
	private PlayerPresenseDetection detection;
	private bool lose = false  ;
	private bool timerIsNeeded = true ;
	public GameObject UI; 
	private UserInrerfaceController UIC;
	 
	public bool removeTimer () {
		return timerIsNeeded;
	}

	void Start () {
		countDownText = countDownText.GetComponent<Text> (); 
		detection = exitTrigger.GetComponent<PlayerPresenseDetection> ();
		UIC = UI.GetComponent<UserInrerfaceController> ();

	}
	
	// Update is called once per frame
	void Update () {
		if( UIC.IsTimePass () ) {
			lose = ! detection.PlayerDetected ();
			timer.CountDown ();
		} 

	}

	public void CountDown () {
		timeLeft -= Time.deltaTime;
		countDownText.text = Convert.ToString (timeLeft + Mathf.Round (timeLeft));
		if (timeLeft < 0 && lose) {
			SceneManager.LoadScene ("GameOver");
		} else if (timeLeft < 0 && !lose) {
			timerIsNeeded = false;
		} 
		 
	}
}
