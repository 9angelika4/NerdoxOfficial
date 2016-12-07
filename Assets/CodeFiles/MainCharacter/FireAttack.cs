using UnityEngine;
using System.Collections;

public class FireAttack : Attack  {

	private ManaController manaContrl;
	void Start (){
		manaContrl = GetComponent<ManaController> ();

	}
	override public void Shot (){
		if (manaContrl.IsEnoughMana ()) {
			base.Shot ();
			manaContrl.UseMana (1.0f);
		}
	}
}
