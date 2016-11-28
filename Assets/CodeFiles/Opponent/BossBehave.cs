using UnityEngine;
using System.Collections;

public class BossBehave : Opponent {

	private Animator animator;
	public AudioClip roar;
	private float distanceWhenWalk = 50;
	private float distanceWhenAttack = 20 ;
	private int distanceWhenRoar   = 60 ;
 
	// Use this for initialization
	void Awake() {
		InitializeOpponent();
		FillTargetInformation ();
	}
	void Start () {
		
		animator = GetComponent <Animator> ();
		 
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		InitializeOpponent();
		FillTargetInformation ();

		if (GetDistanceToTarget () < distanceWhenRoar + 5 && GetDistanceToTarget () > distanceWhenRoar - 5) {
			lookAtPlayer = true;
			Roar ();
			AudioSource.PlayClipAtPoint (roar, transform.position);

		} else if (GetDistanceToTarget () < distanceWhenWalk && GetDistanceToTarget () > distanceWhenAttack) {
			WalkToTarget ();
			WalkAnimation ();
		} else if (GetDistanceToTarget () < distanceWhenAttack) {
			
			Attack ();
		} else {
			
			Idle ();
		}
		watchPlayer (); 
	}

	override public void Activate () {
		base.Activate ();
		animator.enabled = true;
	}
	private void Idle() {
		animator.SetBool ("Roar", false);
		animator.SetBool ("Attack", false);
		animator.SetBool ("Die", false);
		animator.SetBool ("Walk", false);
	}
	private void Attack () {
		animator.SetBool ("Roar", false);
		animator.SetBool ("Attack", true);
		animator.SetBool ("Die", false);
		animator.SetBool ("Walk", false);
	}
	private void Die () {
		animator.SetBool ("Roar", false);
		animator.SetBool ("Attack", false);
		animator.SetBool ("Die", true);
		animator.SetBool ("Walk", false);
	}
	private void Roar (){
		animator.SetBool ("Roar", true);
		animator.SetBool ("Attack", false);
		animator.SetBool ("Die", true);
		animator.SetBool ("Walk", false);
	}
	private void WalkAnimation (){
		animator.SetBool ("Roar", false);
		animator.SetBool ("Attack", false);
		animator.SetBool ("Die", false);
		animator.SetBool ("Walk", true);
	}

}
