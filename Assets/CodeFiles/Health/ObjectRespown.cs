using UnityEngine;
using System.Collections;

public class ObjectRespown : MonoBehaviour {

	void Update () {
		foreach (Transform child in transform) {
			MultipleAppearancesHealt script = child.GetComponent<MultipleAppearancesHealt> ();
				script.RespownWaiting ();
		}
	}
}
