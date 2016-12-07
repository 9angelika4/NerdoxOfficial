using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinnerPlace : MonoBehaviour {

	public GameObject bossHead;
	private void  Awake(){
		bossHead.SetActive (false);

	}
	private void OnTriggerEnter(){
		bossHead.SetActive (true);
		Invoke ("GoWinnerScene", 3);
	}

	private void GoWinnerScene(){
		SceneManager.LoadScene ("WinnerScene");
	}
}
