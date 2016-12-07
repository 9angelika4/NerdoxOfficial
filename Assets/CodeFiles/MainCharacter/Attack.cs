using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public float wait = 0.5f;
	protected float coutingDownToNextShot = 0f;
	 
	public GameObject attackingObject;
	public float speed = 50;

	virtual
	public void Shot () {

		if (coutingDownToNextShot <= 0) {
			coutingDownToNextShot = wait;

			GameObject nextShot;
			nextShot = (GameObject)Instantiate (attackingObject, Camera.main.transform.position + Camera.main.transform.forward, Quaternion.identity);
			nextShot.GetComponent<Rigidbody> ().AddForce (Camera.main.transform.forward * speed, ForceMode.Impulse);

			 
		} else {
			Debug.Log (" waiting" + coutingDownToNextShot);
		}

	}
	public void CoutingDownToNextShot(){
		if (coutingDownToNextShot > 0) {
			coutingDownToNextShot -= Time.deltaTime;
		}
	}

}
