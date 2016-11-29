using UnityEngine;
using System.Collections;

public class darkPeapleBehave : MonoBehaviour {

	 
	public float timer;
	public int newTarget;
	public float speed;
	public NavMeshAgent nav;
	public Vector3 target;

	void Start () {
		nav = gameObject.GetComponent<NavMeshAgent> ();
	}

	void Update () {
		timer += Time.deltaTime;
		if (timer >= newTarget) {
			makeNewTarget ();
			timer = 0;
		}
	}

	void makeNewTarget () {
		float myX = gameObject.transform.position.x;
		float myZ = gameObject.transform.position.z;
	
		float xPos = myX + Random.Range (myX - 100, myX + 100);
		float zPos = myZ + Random.Range (myZ - 100, myZ + 100);
		 
		target = new Vector3 (xPos, gameObject.transform.position.y, zPos);
		 
		nav.SetDestination (target);
	}
 
}
