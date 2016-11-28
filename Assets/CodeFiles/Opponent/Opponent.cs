using UnityEngine;
using System.Collections;

public class Opponent : MonoBehaviour {


	protected Transform target;
	protected Transform opponent;
	protected Vector3 targetPositionXYZ;
	public float attackRange = 20.0f ;
	protected float rotationSpeed = 4.0f;
	public float movementSpeed ;	

	protected bool  smoothRotation = true;
	protected bool lookAtPlayer = false;

	// Use this for initialization
	 
	private void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
 

	}

	protected void InitializeOpponent () {
		opponent = transform;
	}

	protected float GetDistanceToTarget () {
		return Vector3.Distance (opponent.position, target.position);
	}

	protected bool CheckIfTargetIsCloseEnough () {
		if (GetDistanceToTarget () <= attackRange) {
			return true;
		}
		return false;
	}


	protected void FillTargetInformation(){
		target = GameObject.FindWithTag ("Player").transform;
		targetPositionXYZ = new Vector3 (target.position.x, target.position.y, target.position.z);
	}
	public float GetDistanceInformation ( ){

		FillTargetInformation ();
		return GetDistanceToTarget ();
	}

	virtual public void Activate () {
		gameObject.SetActive (true);
	}
	protected void watchPlayer(){
		if (smoothRotation && lookAtPlayer == true) {
			Quaternion rotation = Quaternion.LookRotation (targetPositionXYZ - opponent.position);
			opponent.rotation = Quaternion.Slerp (opponent.rotation, rotation, Time.deltaTime * movementSpeed);

		} else if (!smoothRotation && lookAtPlayer == true) {
			transform.LookAt (targetPositionXYZ);
		}

	}
	protected void WalkToTarget(){
		transform.position = Vector3.MoveTowards (transform.position, targetPositionXYZ, movementSpeed * Time.deltaTime);
	}
}
