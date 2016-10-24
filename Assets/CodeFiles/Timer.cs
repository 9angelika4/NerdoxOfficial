using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour {

	private Canvas timerInterface; 
	private float timeLeft = 70f;
	public Timer timer;
	public Text countDownText ;

	 
	// Use this for initialization
	void Start () {
		timerInterface = (Canvas)GetComponent<Canvas>();
		countDownText = countDownText.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer.CountDown ();
	}

	public void CountDown () {
		timeLeft -= Time.deltaTime;
		countDownText.text = Convert.ToString (timeLeft + Mathf.Round (timeLeft));
		if (timeLeft < 0) {
			SceneManager.LoadScene ("GameOver");


		}
	}
}
