using UnityEngine;
using System.Collections;

public class ObjectRespown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Transform child in transform) {
			Debug.Log (child.name);
			MultipleAppearancesHealt script = child.GetComponent<MultipleAppearancesHealt> ();
				script.RespownWaiting ();
		}

	}
}
