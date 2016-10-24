using UnityEngine;
using System.Collections;

public class onContactExplode : MonoBehaviour {

	public GameObject explosion ;

	void OnCollisionEnter(Collision col ) {
		GameObject expl = Instantiate (explosion, transform.position, Quaternion.identity) as GameObject;
		Destroy (gameObject);
		Destroy (expl, 3);

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
