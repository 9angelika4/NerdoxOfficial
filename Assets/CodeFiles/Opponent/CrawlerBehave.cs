using UnityEngine;
using System.Collections;

public class CrawlerBehave : Opponent {



	private Animator animator;
	public AudioClip attackSound;
 
	private void Awake() {
		InitializeOpponent();
		FillTargetInformation ();
		InitializeDistanceInformation (10, 50);


	}

	void Start () {
		animator = GetComponentInChildren<Animator> ();
		 
	}

	void Update () {
		InitializeOpponent();
		FillTargetInformation ();
		smoothRotation = true;
		float actualDistance = GetDistanceToTarget ();
		if (actualDistance < distanceWhenWalk && actualDistance > distanceWhenAttack ) {
			Walk ();
		} else if (actualDistance < distanceWhenAttack) {
			WalkToTarget ();
			Attack ();
			PlaySound (attackSound);

		} else {
			ResetAudioCondition ();
			DontLookAtPlayer ();
			Idle ();
		}
		WatchPlayer (); 
	}

	override protected void Walk () {
		base.Walk ();
		WalkAnimation ();
		ResetAudioCondition ();
		LookAtPlayer ();
	}

	private void WalkAnimation () {
		animator.SetBool ("Attack", false);
		animator.SetBool ("Walk", true);

	}
	private void Attack(){
		animator.SetBool ("Attack", true);
		animator.SetBool ("Walk", false);
		animator.SetInteger ("AttackNum", Random.Range (1, 3));

	}

	private void Idle () {
		animator.SetBool ("Attack", false);
		animator.SetBool ("Walk", false);
	}
	

}
