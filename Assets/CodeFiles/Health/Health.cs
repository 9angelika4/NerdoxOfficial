using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float healthValue;
	protected bool alive;

 
	void Update () {
		IsAlive ();
		if (!alive) {
			gameObject.SetActive (false);
		}
	}
	public void Damage ( float damageVal) {
 
		healthValue -= damageVal;
		 
	}


	virtual protected void IsAlive () {
		if (healthValue < 0) {
			alive = false;
		} 
		else  {
			alive = true;
		}
	}





}
