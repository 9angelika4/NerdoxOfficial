using UnityEngine;
using System.Collections;

public class DarkMasAttack : Opponent {

	private float timer = 0.0f;
	public GameObject bulletPrefab ;
	private float throwing = 50.0f;
	private float coolDown  = 2.0f;
	private float damage = 5 ;


	void Start () {
		InitializeOpponent ();
		FillTargetInformation ();
	}

	void Update () {
		 
		timer += Time.deltaTime;
		FillTargetInformation ();

		opponent.rotation = Quaternion.Slerp (opponent.rotation, Quaternion.LookRotation (target.position -opponent.position), rotationSpeed * Time.deltaTime);
		if (CheckIfTargetIsCloseEnough ()  && CheckIfCanAttack() ) {
			Attack ();
		}
 	}
	private void Attack () {
		timer = 0.0f;
		if (bulletPrefab != null) {
			GameObject newBullet = (GameObject)Instantiate (bulletPrefab, opponent.position, opponent.rotation);
			newBullet.GetComponent<Rigidbody> ().AddForce (transform.forward * throwing, ForceMode.Impulse);
		}
	} 

 
	private bool CheckIfCanAttack () {
		if (timer >= coolDown) {
			return true;
		}
		return false;
	}
 
	 
}
