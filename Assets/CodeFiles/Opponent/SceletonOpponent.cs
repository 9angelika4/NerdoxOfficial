using UnityEngine;
using System.Collections;

public class SceletonOpponent : Opponent {


	Animator animator;

	public float distanceToStay = 2.0f;

	void Start () {
		InitializeOpponent ();
		FillTargetInformation ();
		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		FillTargetInformation ();
		float actualDistance = GetDistanceToTarget ();
		lookAtPlayer = false;
		if (actualDistance <= attackRange && actualDistance > distanceToStay) {
			lookAtPlayer = true; 
		
			WalkToTarget ();
			Walk ();
		} else if (actualDistance <= distanceToStay) {
			lookAtPlayer = true;
			Attack ();
		}
		else{
			Idle ();
		}
		watchPlayer (); 
 
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
