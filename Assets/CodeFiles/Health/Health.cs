using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float healthValue;
	public float timeToRespown;
	public float countedTimeToRespown;

	public void Damage ( float damageVal) {
		healthValue -= damageVal;

	}


	public bool IsAlive () {
		if (healthValue <= 0) {
			return false;
		}
		return true;
	}

	void Update () {
		if (!IsAlive ()) {
			gameObject.SetActive (false);
		}
	}


}
