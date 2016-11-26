using UnityEngine;
using System.Collections;

public class SceletonOpponent : Opponent {


	Animator animator;
	public bool  smoothRotation = true;
	public float distanceToStay = 2.0f;

	private bool lookAtPlayer = false;


	void Start () {
		InitializeOpponent ();
		FillTargetInformation ();
		animator = GetComponent<Animator> ();


	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (" show " + targetPositionXYZ.x + " " + targetPositionXYZ.y + " " + targetPositionXYZ.z);
		float actualDistance = GetDistanceToTarget ();
		lookAtPlayer = false;
		if (actualDistance <= attackRange && actualDistance > distanceToStay) {
			lookAtPlayer = true; 
			opponent.position = Vector3.MoveTowards (transform.position, targetPositionXYZ, movementSpeed * Time.deltaTime);

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

	void watchPlayer(){
		if (smoothRotation && lookAtPlayer == true) {
			Quaternion rotation = Quaternion.LookRotation (targetPositionXYZ - opponent.position);
			opponent.rotation = Quaternion.Slerp (opponent.rotation, rotation, Time.deltaTime * movementSpeed);

		} else if (!smoothRotation && lookAtPlayer == true) {
			transform.LookAt (targetPositionXYZ);
		}
		
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
