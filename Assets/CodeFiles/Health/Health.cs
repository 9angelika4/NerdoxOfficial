using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float healthValue;
	protected bool alive = true;

 
	void Update () {
		IsAlive ();
		if (!alive) {
			gameObject.SetActive (false);
		}
	}
	public void Damage ( float damageVal) {
 
		healthValue -= damageVal;
		 
	}

	public bool IsDead(){
		if (alive)
			return false;
		return true;
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
