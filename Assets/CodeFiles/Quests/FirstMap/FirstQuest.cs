using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FirstQuest : MonoBehaviour {


	private int howManyShouldKill;
	private int howManyIsKilled;

	public void  DeathCount () {
		Debug.Log ("is killed");
		howManyIsKilled ++ ;
	}
	// Use this for initialization
	void Start () {
		howManyShouldKill = Random.Range (5,20);
		howManyIsKilled = 0;
		Debug.Log ("should be killed" + howManyShouldKill);

	}
	
	// Update is called once per frame
	void Update () {
		if (howManyIsKilled >= howManyShouldKill) {
			LoadScene ();
		}
	}

	private void LoadScene () {
		SceneManager.LoadScene ("Scene2");

	}
}
