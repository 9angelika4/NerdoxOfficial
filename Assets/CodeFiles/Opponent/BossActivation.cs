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
	// Use this for initialization
	void Start () {

		bossBehave.GetDistanceInformation ();
		checkDistance = false;
		isActivated = false;
	}
	
	// Update is called once per frame
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
