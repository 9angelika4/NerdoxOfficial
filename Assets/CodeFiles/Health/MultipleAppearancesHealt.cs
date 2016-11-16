using UnityEngine;
using System.Collections;

public class MultipleAppearancesHealt : Health {

	public void RespownWaiting () {
		if (!IsAlive ()) {
			countedTimeToRespown += 1;
			if (timeToRespown <= countedTimeToRespown) {
				Debug.Log ("respown ");
				countedTimeToRespown = 0; 
				gameObject.SetActive (true);
				healthValue = 100;
			}
		}
	}
	 
}
