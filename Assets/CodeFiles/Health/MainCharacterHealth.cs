using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainCharacterHealth : Health {

	public float maxHealth = 1000;
	 
	void Update () {
		Rescue ();
		IsAlive ();
		if (!alive) {
			SceneManager.LoadScene ("GameOver");
		}
	}

	void Rescue(){
		if (healthValue < maxHealth)
			healthValue += Time.deltaTime;
	}
}
