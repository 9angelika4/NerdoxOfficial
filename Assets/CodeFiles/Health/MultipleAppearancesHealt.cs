using UnityEngine;
using System.Collections;

public class MultipleAppearancesHealt : Health {

	private void Start () {
		firstQuest = gameObject.GetComponentInParent<FirstQuest> ();
	}

	public void RespownWaiting () {
		 
		if (!alive) {
			
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
