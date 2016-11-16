using UnityEngine;
using System.Collections;

public class SceletonOpponent : MonoBehaviour {

	private Transform player;
	private Transform opponent;
	Animator animator;
	public bool  smoothRotation = true;

	 
	public float rotationSpeed = 4.0f;
	public float movementSpeed = 2.0f;
	public float attackRange = 5.0f ;
	public float distanceToStay = 2.0f;

	private bool lookAtPlayer = false;
	private Vector3 playerPositionXYZ;

	void Start () {
		opponent = transform;
		animator = GetComponent<Animator> ();
		 
	}
	
	// Update is called once per frame
	void Update () {
		 
		player = GameObject.FindWithTag ("Player").transform;
		playerPositionXYZ = new Vector3 (player.position.x, player.position.y, player.position.z);
		float actualDistance = Vector3.Distance (opponent.position, player.position);
		lookAtPlayer = false;
		if (actualDistance <= attackRange && actualDistance > distanceToStay) {
	
			lookAtPlayer = true; 
			opponent.position = Vector3.MoveTowards (opponent.position, playerPositionXYZ, movementSpeed * Time.deltaTime);
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
 
	}

	void watchPlayer(){
		if (smoothRotation && lookAtPlayer == true) {
			Quaternion rotation = Quaternion.LookRotation (playerPositionXYZ - opponent.position);
			opponent.rotation = Quaternion.Slerp (opponent.rotation, rotation, Time.deltaTime * movementSpeed);

		} else if (!smoothRotation && lookAtPlayer == true) {
			transform.LookAt (playerPositionXYZ);
		}
	}
}
