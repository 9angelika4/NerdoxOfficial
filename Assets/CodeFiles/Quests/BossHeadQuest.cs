using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BossHeadQuest : MonoBehaviour {

	private void OnTriggerEnter(Collider collider){
		if(collider.gameObject.CompareTag("Player")){
			SceneManager.LoadScene ("LastScene");
		}
	}
}
