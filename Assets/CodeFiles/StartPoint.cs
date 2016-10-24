using UnityEngine;
using System.Collections;

public class StartPoint : MonoBehaviour {

	private Transform trans;
	private bool isStartSet;

	// Use this for initialization
	void Start () {
		trans = GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (!isStartSet) {
			GameObject player = GameObject.FindGameObjectWithTag ("Player");
			if (player != null) {
				GameObject start = null;
				if (PlayerInstance.startPoint != null && !PlayerInstance.startPoint.Equals ("")) {
					start = GameObject.FindGameObjectWithTag (PlayerInstance.startPoint);

				}
				Vector3 position = trans.position;
				if (start != null) {
					position = start.GetComponent<Transform> ().position; 

				}
				player.GetComponent<Transform>().position = position;
				isStartSet = true ;
			}

		}
	}
}
