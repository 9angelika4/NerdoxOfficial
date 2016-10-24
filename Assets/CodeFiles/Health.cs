using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float healthValue;

	public void Damage ( float damageVal) {
		Debug.Log ("get hit");
		healthValue -= damageVal;

	}
	void Update () {
		if (!isAlive ()) {
			Die ();
		}
	}
	void  Die (){
		Destroy (gameObject);

	}
	bool isAlive () {
		if (healthValue <= 0) {
			return false;
		}
		return true;
	}
}
