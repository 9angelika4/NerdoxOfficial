using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour {

	private float lifeDuration = 4.0f;

	void Update () {
		lifeDuration -= Time.deltaTime;
		if (ShouldBeDestroyed ()) {
			Destroy (gameObject);
		}

	}
	private bool ShouldBeDestroyed ( ) {
		if (lifeDuration < 0) {
			return true;
		}
		return false;
	}
}
