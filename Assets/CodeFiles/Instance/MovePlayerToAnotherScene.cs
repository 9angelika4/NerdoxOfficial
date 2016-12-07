using UnityEngine;
using System.Collections;

public class MovePlayerToAnotherScene : MonoBehaviour {

	private Transform transform;
	private bool isSet;

	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform> ();
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		player.transform.position = transform.position;
	
	}
	 
}
