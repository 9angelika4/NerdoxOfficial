using UnityEngine;
using System.Collections;

public class BossHealth : Health {

	private bool isDead = false;
	void Update () {
		IsAlive ();
		if (!alive) {
			isDead = true;
		}
	}

	public bool GetDeathStatus () {
		return isDead;
	}
}
