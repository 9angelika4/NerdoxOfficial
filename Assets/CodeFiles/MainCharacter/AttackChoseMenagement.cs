using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AttackChoseMenagement : MonoBehaviour {

	public AttackTypes attackType = AttackTypes.Rock;
	public Sprite fireAttack;
	public Sprite  fireAttackIdle;
	public Sprite rockAttack;
	public Sprite rockAttackIdle;

	public Image rockImage;
	public Image fireImage;

	private RockAttack rockAttackMenagement;
	private FireAttack fireAttakMenagemnet;

	void Start () {
		rockAttackMenagement = GetComponent<RockAttack> ();
		fireAttakMenagemnet = GetComponent<FireAttack> ();
	}

	void Update () {
		ManageHudImages ();
		CountingDowns ();
		if (Input.GetMouseButtonDown (0) ) {
			MakeShot();
		} 
	}

	private void ManageHudImages(){
		if (Input.GetKeyDown(KeyCode.F)) {
			FirePowerChosen ();
		} else if (Input.GetKeyDown(KeyCode.R)) {
			RockChosen ();
		}
	}

	private void FirePowerChosen () {
		attackType = AttackTypes.Fire;
		rockImage.overrideSprite = rockAttackIdle;
		fireImage.overrideSprite = fireAttack;
	}
	private void RockChosen () {
		attackType = AttackTypes.Rock;
		rockImage.overrideSprite = rockAttack;
		fireImage.overrideSprite = fireAttackIdle;
	}
	private void MakeShot(){
		switch (attackType) {
		case AttackTypes.Rock: 
			if (rockAttackMenagement != null) {
				rockAttackMenagement.Shot ();
			}
			break;
		case AttackTypes.Fire:
			if (fireAttakMenagemnet != null) {
				fireAttakMenagemnet.Shot ();
			}
			break;		
		}
	}
	private void CountingDowns(){
		if (rockAttackMenagement != null) {
			rockAttackMenagement.CoutingDownToNextShot ();
		}
		if (fireAttakMenagemnet != null) {
			fireAttakMenagemnet.CoutingDownToNextShot ();
		}
	}

}
