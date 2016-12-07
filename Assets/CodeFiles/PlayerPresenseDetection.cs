using UnityEngine;
using System.Collections;

public class PlayerPresenseDetection : MonoBehaviour {

	private bool enteredOnTrigger = false  ;

	public bool PlayerDetected () {
		return enteredOnTrigger; 
	}
	void OnTriggerEnter ( Collider other ) {

		if (other.CompareTag ("Player")) {
			enteredOnTrigger = true;
 		}

	}
}
