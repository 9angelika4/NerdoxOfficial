using UnityEngine;
using System.Collections;

public class ShowDialogWindow : MonoBehaviour {

	private TurnDownTextPanel turnDownPanel;
	public GameObject panelManagement ;
	 
	void Start () {

		turnDownPanel = panelManagement.GetComponent<TurnDownTextPanel> ();
	 
	
	}

	void OnTriggerEnter (Collider collider) {
		if( collider.gameObject.tag == "Player"){
			turnDownPanel.turnOnPanel ();
		}
	}

}
