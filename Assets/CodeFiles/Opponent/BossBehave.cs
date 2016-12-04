using UnityEngine;
using System.Collections;

public class BossBehave : Opponent {

	private Animator animator;
	public AudioClip roar;
	public AudioClip dead;
	private int distanceWhenRoar   = 60 ;
	private BossHealth myHealth;
	public GameObject bossHead;
 
	// Use this for initialization
	void Awake() {
		bossHead.SetActive (false);
		InitializeOpponent();
		FillTargetInformation ();
		InitializeDistanceInformation (10, 30);
	}
	void Start () {
		wasPlayed = false;
		animator = GetComponent <Animator> ();
		myHealth = GetComponent<BossHealth> ();
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		InitializeOpponent();
		FillTargetInformation ();
		if (myHealth.GetDeathStatus ()) {
			Die ();
		}else if (GetDistanceToTarget () < distanceWhenRoar + 5 && GetDistanceToTarget () > distanceWhenRoar - 5) {
			LookAtPlayer ();
			Roar ();
			PlaySound (roar);

		} else if (IsTargetCloseEnoughToWalk()) {
			ResetAudioCondition ();
			WalkToTarget ();
			WalkAnimation ();
		} else if (IsTargetCloseEnoughToAttack()) {
			ResetAudioCondition ();
			Attack ();
		} else {
			ResetAudioCondition ();
			Idle ();
		}
		WatchPlayer (); 
	}

	override public void Activate () {
		base.Activate ();
		animator.enabled = true;
	}
	private void Die(){
		DieAnimation ();
		PlaySound (dead);
		Destroy (gameObject,5);
		//bossHead.gameObject.transform = transform;
		bossHead.SetActive (true);
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
		animator.SetInteger ("AttackNum", Random.Range (1, 3));
	}
	private void DieAnimation () {
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
