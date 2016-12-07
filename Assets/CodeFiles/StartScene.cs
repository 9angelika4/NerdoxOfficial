using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

	public void OnStartButtonClick(){
		SceneManager.LoadScene ("MainScene");
	}
}
