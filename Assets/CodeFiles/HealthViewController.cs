using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthViewController : MonoBehaviour {

	private MainCharacterHealth health;
	public Text textField;

	void Start () {
		health = GetComponent<MainCharacterHealth> ();

	}
	
	 
	void Update () {
		textField.text =   Mathf.FloorToInt(health.GetValue()).ToString();
	}
}
