using UnityEngine;
using System.Collections;

public class ShowDialogWindow : MonoBehaviour {

	protected TurnDownTextPanel turnDownPanel;
	public GameObject panelManagement ;
	 
	protected void Initialize(){
		turnDownPanel = panelManagement.GetComponent<TurnDownTextPanel> ();
	}
	void Start () {
		Initialize ();	
	}

	void OnTriggerEnter (Collider collider) {
		if( collider.gameObject.tag == "Player"){
			turnDownPanel.turnOnPanel ();
		}
	}

}
