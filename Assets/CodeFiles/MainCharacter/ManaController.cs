using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManaController : MonoBehaviour {


	private FireAttack fireAttack;
	public Image manaBar;
	public float manaMax = 5;
	private float manaLeft;
	 
	void Start () {
		fireAttack = GetComponent<FireAttack> ();
		manaLeft = manaMax;
	}
	private void Update(){
		 
	
		manaLeft += Time.deltaTime/5;
		UpdateManaBar ();
		 
	}
	public void UpdateManaBar(){
		if (manaBar != null) {
			manaBar.fillAmount = manaLeft / manaMax;
		}
	}

	public void UseMana (float valueLose) {
		manaLeft -= valueLose;
	}
	public bool IsEnoughMana(){
		if (manaLeft > 0)
			return true;
		return false;
	}
}
