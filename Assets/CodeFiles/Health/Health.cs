using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float healthValue;
	public float timeToRespown;
	protected float countedTimeToRespown;
	protected FirstQuest firstQuest;
	protected bool alive;
	public void Damage ( float damageVal) {
		healthValue -= damageVal;

	}


	public void IsAlive () {
		if (healthValue <= 0) {
			if (alive) {
				firstQuest.DeathCount ();
			}
			alive = false;
		} 
		else {
			alive = true;
		}
	}

	void Update () {
		IsAlive ();
		if (!alive) {
			gameObject.SetActive (false);
		}
	}


}
