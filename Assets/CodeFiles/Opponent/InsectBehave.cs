using UnityEngine;
using System.Collections;

public class InsectBehave : Opponent {

	private Animator animator;
	public  AudioClip attackSound;
	private void Awake () {
		InitializeDistanceInformation (5, 50);

	}
	// Use this for initialization
	void Start () {
		animator= GetComponent<Animator> ();
		FillingOponentAndTargetInformation ();

	}
	
	// Update is called once per frame
	void Update () {
		FillingOponentAndTargetInformation ();
		if (IsTargetCloseEnoughToWalk ()) {
			Walk ();
		} else if(IsTargetCloseEnoughToAttack()) {
			Attack();
		}else {
			Idle ();
		}
	}

	override protected void Walk (){
		base.Walk ();
		WalkAnimation ();
		ResetAudioCondition ();
	}
	private void Idle(){
		IdleAnimation ();
		ResetAudioCondition ();
	}
	private void Attack () {
		AttackAnimation ();
		PlaySound (attackSound);

	}
	private void WalkAnimation () {
		animator.SetBool ("Walk", true);
		animator.SetBool ("Attack", false);

	}

	private void IdleAnimation () {
		animator.SetBool ("Walk", false);
		animator.SetBool ("Attack", false);

	}
	private void AttackAnimation() {
		animator.SetBool ("Attack", true);
		animator.SetInteger ("AttackNum", Random.Range (1, 3));
		animator.SetBool ("Walk", false);
	}
}
