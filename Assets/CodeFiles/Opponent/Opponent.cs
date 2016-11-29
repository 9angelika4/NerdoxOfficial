using UnityEngine;
using System.Collections;

public class Opponent : MonoBehaviour {


	protected Transform target;
	protected Transform opponent;
	protected Vector3 targetPositionXYZ;

	protected float rotationSpeed = 4.0f;
	public float movementSpeed ;	
 

	protected float distanceWhenWalk  ;
	protected float distanceWhenAttack ;

	protected bool  smoothRotation = true;
	protected bool lookAtPlayer = false;
	protected bool wasPlayed = false;

	protected AudioSource sound;
	 

	protected void InitializeDistanceInformation (float dWhenAttack , float dWhenWalk){
		distanceWhenAttack = dWhenAttack;
		distanceWhenWalk = dWhenWalk;
	}

	protected void InitializeOpponent () {
		opponent = transform;
	}

	protected float GetDistanceToTarget () {
		return Vector3.Distance (opponent.position, target.position);
	}

	protected bool CheckIfTargetIsCloseEnough () {
		if (GetDistanceToTarget () <= distanceWhenWalk) {
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
	virtual protected void WatchPlayer(){
		if (smoothRotation && lookAtPlayer == true) {
			Quaternion rotation = Quaternion.LookRotation (targetPositionXYZ - opponent.position);
			opponent.rotation = Quaternion.Slerp (opponent.rotation, rotation, Time.deltaTime * movementSpeed);

		} else if (!smoothRotation && lookAtPlayer == true) {
			transform.LookAt (targetPositionXYZ);
		}

	}
	protected void WalkToTarget(){
		opponent.position = Vector3.MoveTowards (opponent.position, targetPositionXYZ, movementSpeed * Time.deltaTime);
	}

	protected void  FillingOponentAndTargetInformation () {
		InitializeOpponent ();
		FillTargetInformation ();
	}
	protected bool IsTargetCloseEnoughToWalk(){
		if (GetDistanceToTarget () < distanceWhenWalk && GetDistanceToTarget () > distanceWhenAttack) {
			return true;
		}
		return false;
	}
	protected bool IsTargetCloseEnoughToAttack () {
		if (GetDistanceToTarget () < distanceWhenAttack  ) {
			return true;
		}
		return false;
	}
	virtual protected void Walk () {
		LookAtPlayer ();
		WatchPlayer ();
		WalkToTarget ();
	}
	protected void LookAtPlayer(){
		lookAtPlayer = true;
	}
	protected void DontLookAtPlayer(){
		lookAtPlayer = false;
	}

	protected void PlaySound ( AudioClip audio  ){
		sound = GetComponent<AudioSource> ();
		if (!wasPlayed) {
			sound.PlayOneShot (audio, 0.5f);
			wasPlayed = true;
		}
	}

	protected void ResetAudioCondition(){
		wasPlayed = false;
	}
}
