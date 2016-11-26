using UnityEngine;
using System.Collections;

public class Opponent : MonoBehaviour {


	protected Transform target;
	protected Transform opponent;
	protected Vector3 targetPositionXYZ;
	public float attackRange = 20.0f ;
	public float rotationSpeed = 4.0f;
	public float movementSpeed = 2.0f;
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

}
