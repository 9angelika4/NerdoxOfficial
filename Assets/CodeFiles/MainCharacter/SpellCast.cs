using UnityEngine;
using System.Collections;

public class SpellCast : MonoBehaviour {

	public Transform spawn;
	public GameObject spell ;
	public int spellSpeed;


	public float range = 100f;
	public float wait = 2f;
	public float waitTillAttack  = 0f;
	public float damage = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if( Input.GetButtonDown("Fire1")){
			Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
			RaycastHit hitInfo;
			Debug.Log ("fire1 !");
			if(Physics.Raycast(ray, out hitInfo, range)) {
				  
				Vector3 hitPoint = hitInfo.point ;
				GameObject hittedObject = hitInfo.collider.gameObject;
				Debug.Log ("Hit Object : " + hittedObject.name);

				hit(hittedObject);
				GameObject magic = Instantiate (spell, hitPoint, spawn.rotation) as GameObject;
				magic.GetComponent<Rigidbody>().AddForce (spawn.forward * spellSpeed);
 
			}


		}
	
	}

	void hit (GameObject hittedObject ) {
		Health health = hittedObject.GetComponent < Health> ();
		if (health != null) {
			health.Damage (damage);
		}
	}

}
