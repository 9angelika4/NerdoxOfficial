using UnityEngine;
using System.Collections;

public class DoorHandler : MonoBehaviour {

	private Animator animator = null;
	private bool locked ;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		locked = true;

	}

	void OnTriggerEnter ( Collider collider ) {
		if(collider.CompareTag("Player") && !locked){
			OpenTheDoor ();
		}
	}

	void OnTriggerExit (Collider collider) {
		if(collider.CompareTag("Player") && !locked){
			CloseTheDoor ();
		} 
	}


	private void CloseTheDoor () {
		animator.SetBool ("IsOpen", false);
	}

	private void OpenTheDoor(){
		animator.SetBool ("IsOpen", true);
	}

	public void  UnlockTheDorr () {
		locked = false;
	}
}
