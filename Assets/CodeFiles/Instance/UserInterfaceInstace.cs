using UnityEngine;
using System.Collections;

public class UserInterfaceInstace : MonoBehaviour {

	public static UserInterfaceInstace localUIInstance;

	void Awake () {
		if (!localUIInstance) {
			DontDestroyOnLoad (this.gameObject);
			localUIInstance = this;
		} else {
			Destroy (gameObject);

		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
