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

}