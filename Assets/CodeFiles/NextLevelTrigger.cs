using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NextLevelTrigger : MonoBehaviour {
	 
	public string newSceneName ;
	public string startPoint;
	private bool canGoToNextScene = false  ;

 
	void OnTriggerEnter ( Collider other ) {
		 
		if (other.CompareTag ("Player") && canGoToNextScene ) {
			 
			SceneManager.LoadScene (newSceneName);
			PlayerInstance.startPoint = startPoint;

		}

	}

}
