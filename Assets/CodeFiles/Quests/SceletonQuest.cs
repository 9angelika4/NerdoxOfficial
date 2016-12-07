using UnityEngine;
using System.Collections;

public class SceletonQuest : DeathQuestEnd {

	public GameObject door ;
	private DoorHandler doorHandler;

	void Start () {
		Initialize ();
		doorHandler = door.GetComponent<DoorHandler> ();
	}
 
	void Update () {
		
		if ( getDeadQuestStatus ()) {
			UnlockTheDoor ();
		}
	}

	private void UnlockTheDoor (){
		doorHandler.UnlockTheDorr ();
	}
}
