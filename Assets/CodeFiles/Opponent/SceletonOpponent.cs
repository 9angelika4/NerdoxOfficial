using UnityEngine;
using System.Collections;

public class SceletonOpponent : Opponent {


	Animator animator;

	private void Awake (){
		InitializeDistanceInformation (2, 20);
	}

	void Start () {
		InitializeOpponent ();
		FillTargetInformation ();
		animator = GetComponent<Animator> ();

	}

	void Update () {
		FillTargetInformation ();
		float actualDistance = GetDistanceToTarget ();
		lookAtPlayer = false;
		if (actualDistance <= distanceWhenWalk && actualDistance > distanceWhenAttack) {
			lookAtPlayer = true; 
			WalkToTarget ();
			Walk ();
		} else if (actualDistance <= distanceWhenAttack) {
			lookAtPlayer = true;
			Attack ();
		}
		else{
			Idle ();
		}
		WatchPlayer (); 
 
	}


	private void Walk () {
		animator.SetBool ("isWalking", true);
		animator.SetBool ("isIdle", false);
		animator.SetBool ("isAttacking", false);
	}
	private void Idle(){
		animator.SetBool ("isWalking", false);
		animator.SetBool ("isIdle", true);
		animator.SetBool("isAttacking",false);
	}
	private void Attack(){
		animator.SetBool("isWalking",false);
		animator.SetBool("isAttacking",true);
		animator.SetBool ("isIdle", false);
	}
}
