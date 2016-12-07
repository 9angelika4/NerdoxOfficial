using UnityEngine;
using System.Collections;

public class BossActivation : MonoBehaviour   {

	private BossBehave bossBehave;
	private float distanceToActivate  = 80 ;
	private bool checkDistance ;
	private bool isActivated;

	void Awake(){
		bossBehave = GetComponentInChildren<BossBehave> ();
	}

	void Start () {

		bossBehave.GetDistanceInformation ();
		checkDistance = false;
		isActivated = false;
	}

	void Update () {
		if ( bossBehave.GetDistanceInformation () < distanceToActivate && checkDistance && !isActivated) {
			Activation ();
		}
		checkDistance = true;
	}

	virtual protected  void Activation () {
		bossBehave.Activate ();
		isActivated = true;
	}
}
