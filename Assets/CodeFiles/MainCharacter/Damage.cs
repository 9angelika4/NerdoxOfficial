using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	public float damage ;

	void OnCollisionEnter(Collision collider ){  
		Health health = collider.gameObject.GetComponent < Health> ();
		if (health == null) {
			health = collider.gameObject.GetComponentInParent<Health> ();
		}
		if (health != null) {
			health.Damage (damage);
		}
	}
}
