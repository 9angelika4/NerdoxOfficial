using UnityEngine;
using System.Collections;

public class SceletonQuest : DeathQuestEnd {

	public GameObject door ;
	private DoorHandler doorHandler;
	// Use this for initialization
	void Start () {
		Initialize ();
		doorHandler = door.GetComponent<DoorHandler> ();

	}
	
	// Update is called once per framewwwwwwwwwww
	void Update () {
		
		if ( getDeadQuestStatus ()) {
			UnlockTheDoor ();
		}
	}

	private void UnlockTheDoor (){
		doorHandler.UnlockTheDorr ();
	}
}
