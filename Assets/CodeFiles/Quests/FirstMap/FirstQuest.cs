using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FirstQuest : MonoBehaviour {


	private int howManyShouldKill;
	private int howManyIsKilled;

	public void  DeathCount () {
		howManyIsKilled ++ ;
	}

	void Start () {
		howManyShouldKill = Random.Range (5,20);
		howManyIsKilled = 0;
	}
	

	void Update () {
		if (howManyIsKilled >= howManyShouldKill) {
			LoadScene ();
		}
	}

	private void LoadScene () {
		SceneManager.LoadScene ("Scene2");
	}
}
