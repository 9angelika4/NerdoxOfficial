using UnityEngine;
using System.Collections;

public class DeathQuestEnd : MonoBehaviour {


	protected DeathCount deathCount;

	protected void Initialize () {
		deathCount = gameObject.GetComponent<DeathCount> ();
	}
	protected bool getDeadQuestStatus () {
		if (deathCount.getDeathStatus ()) {
			return true;
		} else {
			return false;
		}
	}

}
