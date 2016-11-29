using UnityEngine;
using System.Collections;
using System; 
public class HitDetection : MonoBehaviour {


	public int damageVal ;

	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter ( Collider other ){
		if (other.CompareTag ("Player")) {
			Debug.Log ("hitted player");
			try {
				Health health = other.GetComponent<Health> ();
				health.Damage (damageVal);
			}
			catch(  NullReferenceException  ) {
				Debug.Log (" exception has been thrown");
			}
		}
	}
}
