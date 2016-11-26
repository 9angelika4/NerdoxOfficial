using UnityEngine;
using System.Collections;

public class SceletonOpponent : Opponent {


	Animator animator;
	public bool  smoothRotation = true;

	 



	public float distanceToStay = 2.0f;

	private bool lookAtPlayer = false;


	void Start () {

		animator = GetComponent<Animator> ();
		 
	}
	
	// Update is called once per frame
	void Update () {
		 
	
		/*
		float actualDistance =
		lookAtPlayer = false;
		if (actualDistance <= attackRange && actualDistance > distanceToStay) {
	
			lookAtPlayer = true; 
			opponent.position = Vector3.MoveTowards (opponent.position, targetPositionXYZ, movementSpeed * Time.deltaTime);
			animator.SetBool ("isWalking", true);
			animator.SetBool ("isIdle", false);
			animator.SetBool ("isAttacking", false);
		} else if (actualDistance <= distanceToStay) {
			lookAtPlayer = true;
			animator.SetBool("isWalking",false);
			animator.SetBool("isAttacking",true);
			animator.SetBool ("isIdle", false);
		}
		else{
			
			animator.SetBool ("isWalking", false);
			animator.SetBool ("isIdle", true);
			animator.SetBool("isAttacking",false);
		}
		watchPlayer (); 
 */
	}

	void watchPlayer(){
		/*if (smoothRotation && lookAtPlayer == true) {
			Quaternion rotation = Quaternion.LookRotation (playerPositionXYZ - opponent.position);
			opponent.rotation = Quaternion.Slerp (opponent.rotation, rotation, Time.deltaTime * movementSpeed);

		} else if (!smoothRotation && lookAtPlayer == true) {
			transform.LookAt (playerPositionXYZ);
		}*/
	}
}
