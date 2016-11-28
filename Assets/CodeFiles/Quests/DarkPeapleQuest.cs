using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class DarkPeapleQuest : DeathQuestEnd {

	public string sceneName;
	// Use this for initialization
	void Start () {
		Initialize ();
	}
	
	// Update is called once per frame
	void Update () {
		if ( getDeadQuestStatus ()) {
			LoadScene ();
		}
	}
	private void LoadScene () {
		SceneManager.LoadScene (sceneName);
	}
}
