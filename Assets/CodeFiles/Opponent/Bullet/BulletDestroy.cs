using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour {

	private float lifeDuration = 4.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
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
