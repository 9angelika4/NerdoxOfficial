using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float healthValue;
	public float timeToRespown;
	protected float countedTimeToRespown;
	protected DeathCount deathCount;
	protected bool alive;


	protected void Initialize () {
		deathCount = gameObject.GetComponentInParent<DeathCount> ();

	}

	public void Damage ( float damageVal) {
		healthValue -= damageVal;
		 
	}


	protected void IsAlive () {
		if (healthValue < 0) {
			bool prevAlive = alive;
			Debug.Log (" before");
			alive = false;
			if (prevAlive) {
				Debug.Log ("im here ");
				deathCount.AddOneDeath ();
			}
 		} 
		else  {
			alive = true;
 
		}
	 
	}

	void Update () {
		IsAlive ();
		if (!alive) {
			Debug.Log ("DEAD");
			gameObject.SetActive (false);
		}
	}


}
