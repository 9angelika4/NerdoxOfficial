using UnityEngine;
using System.Collections;

public class MultipleAppearancesHealt : Health {

	private DeathCount deathCount;
	public float timeToRespown;
	private float countedTimeToRespown;

	private void Start () {
		deathCount = gameObject.GetComponentInParent<DeathCount> ();
	}




	public void RespownWaiting () {
		 
		if (!alive) {
			countedTimeToRespown += 1;
			if (timeToRespown <= countedTimeToRespown) {
				countedTimeToRespown = 0; 
				gameObject.SetActive (true);
				healthValue = 100;
			}
		}
	}

	private void SendDeathMessage (bool prevLifeStatus) {
		if (prevLifeStatus && deathCount) {
			deathCount.AddOneDeath ();

		}
	}
	override protected void IsAlive () {
		if (healthValue < 0) {
			bool prevAlive = alive;
			alive = false;
			if (prevAlive && deathCount) {
				deathCount.AddOneDeath ();

			}
		} 
		else  {
			alive = true;

		}

	}
}
