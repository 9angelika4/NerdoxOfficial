using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class KillingParticleTrigger : MonoBehaviour {

	public float damage = 10;
	void OnTriggerEnter ( Collider other ) {

		if (other.CompareTag ("Player")   ) {

			other.gameObject.GetComponent<MainCharacterHealth> ().Damage (damage); 
		}

	}
		 
}
