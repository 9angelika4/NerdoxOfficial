using UnityEngine;
using System.Collections;

public class MultipleAppearancesHealt : Health {

	private void Start () {
		Initialize ();
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
	 
}
